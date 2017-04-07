imports System
imports System.Configuration
Imports Microsoft.VisualBasic

Imports MongoDB

Namespace Simple

    '''<summary>
    '''Illustrates some simple operations on the database.
    '''Creating a database connection.
    '''Remove some documents.
    '''Insert some documents
    '''Find one document
    '''Find several documents and iterate through them.
    '''</summary>
    Public Class Application
        Private mongo as Mongo
        Private simple as IMongoDatabase
        Private categories As IMongoCollection(Of Document)
        
        Public Shared Sub Main()
            Dim app As New Application()
            
            app.Setup()
            app.Run()
            Console.WriteLine("Press any key to continue...")
            Console.ReadKey()
        End Sub
        
        ''' <summary>
        ''' Setup the collection and insert some data into it.
        ''' </summary>
        Public Sub Setup()
            dim connstr as string  = ConfigurationManager.AppSettings("simple")
            if String.IsNullOrEmpty(connstr) then throw new ArgumentNullException("Connection string not found.")
            mongo = new Mongo(connstr)
            mongo.Connect()
            simple = mongo("simple")
            categories = simple.GetCollection(Of Document)("categories")
            Clean()
            
            Dim names() As String = {"Bluez", "Jazz", "Classical", "Rock", "Oldies", "Heavy Metal"}

            For Each name As string In names
                categories.Insert(New Document().Add("name", name))
            Next
        End Sub
        
        Public Sub Clean()
            categories.Remove(New Document().Add("name", "Jazz")) 'remove documents with the name Jazz.
            categories.Remove(New Document()) 'remove everything from the categories collection.
        End Sub
        Public Sub Run()
            Dim category As Document = categories.FindOne(New Document().Add("name", "Bluez"))
            
            Console.WriteLine ("The id findOne" & category("_id").ToString())
            
            Dim selector As Document = New Document().Add("_id", category("_id"))
            
            category("name") = "Bluess"
            'The following will do the same thing.
            categories.Save(category)
            
            Console.WriteLine("Category after one update " + categories.FindOne(selector).ToString())
            
            category("name") = "Blues"
            categories.Update(category, selector)
            
            Console.WriteLine("Category after two updates " + categories.FindOne(selector).ToString())
            
            'Find it by _id that has been converted to a string now.
            Dim id As String = CType(category("_id"),Oid).ToString()
            
            Console.WriteLine("Found by string id converted back to Oid")
            Console.WriteLine(categories.FindOne(New Document().Add("_id", New Oid(id.Replace("""", "")))).ToString())

            'Find(new Document()) is equivalent to FindAll()
            'Specifying the cursor in a using block will close it on the server if we decide not
            'to iterate through the whole thing.
            Dim all As ICursor(Of Document) = categories.Find(New Document())
            Try
                For Each doc As Document In all.Documents
                    Console.WriteLine(doc.ToString())
                Next
            Finally
                all.Dispose()
            End Try
            
            mongo.Disconnect()
        End Sub
                
    End Class

End Namespace

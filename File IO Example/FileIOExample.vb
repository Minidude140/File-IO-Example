'Zachary Christensen
'9/12/24
'File IO Examples
'Documentation: https://learn.microsoft.com/en-us/dotnet/api/microsoft.visualbasic.filesystem.write?view=netframework-4.7.2#Microsoft_VisualBasic_FileSystem_Write_System_Int32_System_Object___


Module FileIOExample

    Sub Main()
        Dim allRecords As New List(Of String)
        WriteToFile()
        AppendToFile()
        ReadFromFile(allRecords)
        Console.Read()
    End Sub

    Sub WriteToFile()
        'Open File
        'Openmode.output will erase the file and rewrite with the info provided
        FileOpen(1, "..\..\myCrazyFile.txt", OpenMode.Output)
        'Write String to file 1
        Write(1, "Wake up Mr. Freeman.... Wake up and smell the ashes.")
        FileClose(1)
    End Sub

    Sub AppendToFile()
        'Open File
        'Openmode.Append will Concatenate to the end of what is already in the file
        FileOpen(1, "..\..\myCrazyFile.txt", OpenMode.Append)
        'Write String to file 1 with included line break
        WriteLine(1)
        WriteLine(1, "The right man in the wrong place can make all the difference in the world.")
        FileClose(1)
    End Sub

    Sub ReadFromFile(ByRef allRecords As List(Of String))
        Dim currentRecord As String
        FileOpen(1, "..\..\myCrazyFile.txt", OpenMode.Input)
        Do Until EOF(1)
            Input(1, currentRecord)
            Console.WriteLine(currentRecord)
            allRecords.Add(currentRecord)
        Loop
        FileClose(1)
    End Sub
End Module

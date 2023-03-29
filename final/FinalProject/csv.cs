using System;
using Microsoft.VisualBasic.FileIO;
public class CSV{
    private string _csvSource;
    private List<CSVLine> _csvLines = new List<CSVLine>();
    public CSV(string csvSource){
        _csvSource = csvSource;
        using( TextFieldParser textParser = new TextFieldParser(_csvSource)){
            textParser.TextFieldType = FieldType.Delimited;
            textParser.SetDelimiters(",");
            textParser.ReadFields();
            while (!textParser.EndOfData){
                
                CSVLine newRow = new CSVLine(textParser.ReadFields());
                _csvLines.Add(newRow);
            }
        }
    }
    public List<CSVLine> GetCSV(){
        return _csvLines;
    }
}

public class CSVLine{
    private List<string> _csvLine = new List<string>();
    public CSVLine(params string[] fields)
    {
        foreach (string option in fields)
        {
            _csvLine.Add(option);
        }
    }
    public List<string> GetFields(){
        return _csvLine;
    }
}
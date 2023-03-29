public class Drilling{
    private List<Drill> _drills = new List<Drill>();
    private string _drillFile = "drills.csv";
    public Drilling(){
        CSV drillCSV = new CSV(_drillFile);
        foreach (CSVLine line in drillCSV.GetCSV())
        {
            Console.WriteLine("");
            foreach (string field in line.GetFields())
            {
                Console.Write(field+",");
            }
        }
        Console.WriteLine(drillCSV.GetCSV());
    }
}
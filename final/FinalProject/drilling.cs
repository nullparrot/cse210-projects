public class Drilling{
    private List<Drill> _drills = new List<Drill>();
    private string _drillFile = "drills.csv";
    public Drilling(){
        CSV drillCSV = new CSV(_drillFile);
        foreach (CSVLine line in drillCSV.GetCSV())
        {
            List<string> tempList = line.GetFields();
            double metric;
            double.TryParse(tempList[2],out metric);
            _drills.Add(new Drill(double.Parse(tempList[3]),tempList[1],tempList[0],metric));
        }
    }
    public List<Drill> SearchDrills(double min, double max){
        List<Drill> results = new List<Drill>();
        foreach (Drill oneDrill in _drills)
        {
            if(oneDrill.GetSize() <= max & oneDrill.GetSize()>=min){
                results.Add(oneDrill);
            }
        }
        return results;
    }
}
public class Tapping{
    private List<Tap> _taps = new List<Tap>();
    private string _ansiFile = "ansi-taps.csv";
    public string _metricFile = "metric-taps.csv";
    public Tapping(string type){
        string tapSource;
        switch(type){
            case "ansi":
            tapSource = _ansiFile;
            break;
            case "metric":
            tapSource = _metricFile;
            break;
            default:
            tapSource = _ansiFile;
            break;
        }
        CSV tapCSV = new CSV(tapSource);
        foreach (CSVLine line in tapCSV.GetCSV())
        {
            List<string> tempList = line.GetFields();
            switch(tempList[2]){
                case "Metric":
                _taps.Add(new MetricTap(tempList[0],tempList[1],double.Parse(tempList[3]),double.Parse(tempList[4])));
                break;
                case "ANSI":
                _taps.Add(new ANSITap(tempList[0],tempList[1],double.Parse(tempList[3]),double.Parse(tempList[4])));
                break;
            }
            
        }
    }
    public Tap ChooseTap(){
        List<string> tapNameList = new List<string>();
        foreach (Tap oneTap in _taps)
        {
            tapNameList.Add(oneTap.GetTapName());
        }
        Menu myTapsMenu = new Menu(tapNameList.ToArray());
        string chosenTap = myTapsMenu.ChooseOne("Which tap would you like to use?");
        return _taps[myTapsMenu.GetChoiceNumber()-1];

    }
    public void CutTap(Tap oneTap){
        Drilling letsDrill = new Drilling();
        List<Drill> drillChoices = letsDrill.SearchDrills(oneTap.GetMinorMin(),oneTap.GetMinorMax());
        Console.Clear();
            Console.WriteLine($"Here are the drills that work for a {oneTap.GetTapName()} tap:");
        foreach (Drill oneDrill in drillChoices)
        {
            Console.WriteLine($"{oneDrill.GetSize().ToString()} in | Gauge:{oneDrill.GetGauge()} | Fraction:{oneDrill.GetFraction()} in | Metric:{oneDrill.GetMetric().ToString()} mm");
        }
    }
    public void DisplayTapData(Tap oneTap){
            Console.WriteLine($"{oneTap.GetTapName()} - Minor Diameter Min: {oneTap.GetMinorMin()}in - Major Diameter Max: {oneTap.GetMinorMax()}in");
    }
    public void DisplayAllTaps(){
        foreach (Tap oneTap in _taps)
        {
            DisplayTapData(oneTap);
        }
    }
}
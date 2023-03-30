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
            _taps.Add(new Tap(tempList[0],tempList[1],tempList[2],double.Parse(tempList[3]),double.Parse(tempList[4])));
        }
    }
    public Tap ChooseTap(){
        List<string> tapNameList = new List<string>();
        foreach (Tap oneTap in _taps)
        {
            switch(oneTap.GetTapType()){
                case "ANSI":
                tapNameList.Add($"{oneTap.GetSize()}-{oneTap.GetPitch()}");
                break;
                case "Metric":
                tapNameList.Add($"{oneTap.GetSize()}x{oneTap.GetPitch()}");
                break;
            }
        }
        Menu myTapsMenu = new Menu(tapNameList.ToArray());
        string chosenTap = myTapsMenu.ChooseOne("Which tap would you like to use?");
        return _taps[myTapsMenu.GetChoiceNumber()-1];

    }
    public void CutTap(Tap oneTap){
        Drilling letsDrill = new Drilling();
        List<Drill> drillChoices = letsDrill.SearchDrills(oneTap.GetMinorMin(),oneTap.GetMinorMax());
        switch(oneTap.GetTapType()){
            case "ANSI":
                Console.WriteLine($"Here are the drills that work for a {oneTap.GetSize()}-{oneTap.GetPitch()} tap:");
            break;
            case "Metric":
            Console.WriteLine($"Here are the drills that work for a {oneTap.GetSize()}x{oneTap.GetPitch()} tap:");
            break;
        }
        foreach (Drill oneDrill in drillChoices)
        {
            Console.WriteLine($"{oneDrill.GetSize().ToString()} in | Gauge:{oneDrill.GetGauge()} | Fraction:{oneDrill.GetFraction()} in | Metric:{oneDrill.GetMetric().ToString()} mm");
        }
    }
    public void DisplayTapData(Tap oneTap){
        switch(oneTap.GetTapType()){
            case "ANSI":
                Console.WriteLine($"{oneTap.GetSize()}-{oneTap.GetPitch()} - Minor Diameter Min: {oneTap.GetMinorMin()}in - Major Diameter Max: {oneTap.GetMinorMax()}in");
            break;
            case "Metric":
            Console.WriteLine($"{oneTap.GetSize()}x{oneTap.GetPitch()} - Minor Diameter Min: {oneTap.GetMinorMin()}in - Major Diameter Max: {oneTap.GetMinorMax()}in");
            break;
        }
    }
    public void DisplayAllTaps(){
        foreach (Tap oneTap in _taps)
        {
            DisplayTapData(oneTap);
        }
    }
}
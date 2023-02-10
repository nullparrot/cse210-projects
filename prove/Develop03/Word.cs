public class Words{
    private List<string> _words = new List<string>();

    public Words(){

    }
    public Words(string scripture){
        scripture.Split(" ");
    }
}
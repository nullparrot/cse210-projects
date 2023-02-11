public class Scripture{
    private string _scripture;
    private string _reference;
    private string _topic;
    private string _book;
    public Scripture(){
        TSVParser scriptureTSV = new TSVParser("scriptures.tsv");
        string[] scriptureinfo = scriptureTSV.GetRandomLine().Split("	");
        _topic =  scriptureinfo[0];
        _book = scriptureinfo[1];
        _reference = scriptureinfo[2];
        _scripture = scriptureinfo[3];
        //_scripture = "3 Thou shalt have no other gods before me.|4 Thou shalt not make unto thee any graven image, or any likeness of any thing that is in heaven above, or that is in the earth beneath, or that is in the water under the earth:|5 Thou shalt not bow down thyself to them, nor serve them: for I the Lord thy God am a jealous God, visiting the iniquity of the fathers upon the children unto the third and fourth generation of them that hate me;|6 And shewing mercy unto thousands of them that love me, and keep my commandments.|7 Thou shalt not take the name of the Lord thy God in vain; for the Lord will not hold him guiltless that taketh his name in vain.|8 Remember the sabbath day, to keep it holy.|9 Six days shalt thou labour, and do all thy work:|10 But the seventh day is the sabbath of the Lord thy God: in it thou shalt not do any work, thou, nor thy son, nor thy daughter, thy manservant, nor thy maidservant, nor thy cattle, nor thy stranger that is within thy gates:|11 For in six days the Lord made heaven and earth, the sea, and all that in them is, and rested the seventh day: wherefore the Lord blessed the sabbath day, and hallowed it.|12 Honour thy father and thy mother: that thy days may be long upon the land which the Lord thy God giveth thee.|13 Thou shalt not kill.|14 Thou shalt not commit adultery.|15 Thou shalt not steal.|16 Thou shalt not bear false witness against thy neighbour.|17 Thou shalt not covet thy neighbour's house, thou shalt not covet thy neighbour's wife, nor his manservant, nor his maidservant, nor his ox, nor his ass, nor any thing that is thy neighbour's.";
        //_reference = "Exodus 20:3-17";
    }

    public Scripture(string scripture){
        _scripture = scripture;
        _reference = "";
        _topic = "";
        _book = "";
    }

    public Scripture(string scripture, string reference){
        _scripture = scripture;
        _reference = reference;
        _topic = "";
        _book = "";
    }
    public Scripture(string scripture, string reference, string book){
        _scripture = scripture;
        _reference = reference;
        _topic = "";
        _book = book;
    }
    public Scripture(string scripture, string reference, string book,string topic){
        _scripture = scripture;
        _reference = reference;
        _topic = topic;
        _book = book;
    }
    public void SetScripture(string scripture){
        _scripture = scripture;
    }

    public void SetScripture(string scripture, string reference){
        _scripture = scripture;
        _reference = reference;
    }

    public void SetReference(string reference){
        _reference = reference;
    }

    public string GetScripture(){
        return _scripture;
    }

    public string GetReference(){
        return _reference;
    }
    public string GetBook(){
        return _book;
    }
    public string GetTopic(){
        return _topic;
    }

}
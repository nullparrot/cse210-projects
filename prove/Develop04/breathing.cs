using System.Diagnostics;
public class Breathing : Activity{
    private string _description = "Breath in and out";
    private int _breatheGap = 4;

    public Breathing() :base("Breathing Activity","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."){
        int dura = GetDuration();
        Stopwatch s = new Stopwatch();
        bool inhale = true;
        s.Start();
        do
        {
            if (inhale){
                // Thread.Sleep(_breatheGap);
                // Console.Write("\rBreathe In ");
                Pause("Breathe In ",_breatheGap,1);
                inhale = false;

            } else{
                // Thread.Sleep(_breatheGap);
                // Console.Write("\rBreathe Out");
                Pause("Breathe Out",_breatheGap,1);
                inhale = true;
            }
        } while (s.Elapsed < TimeSpan.FromSeconds(dura));
    }
    private void CountDown(){
        
    }
}
using System.Diagnostics;
public class Breathing : Activity{
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
                 Console.WriteLine("\n");
                CountDown("Breathe In ",_breatheGap);
                inhale = false;

            } else{
                // Thread.Sleep(_breatheGap);
                // Console.Write("\rBreathe Out");
                Console.WriteLine("\n");
                CountDown("Breathe Out",_breatheGap);
                inhale = true;
            }
        } while (s.Elapsed < TimeSpan.FromSeconds(dura));
        ActivityGoodbye();
    }
    private void CountDown(){
        
    }
}
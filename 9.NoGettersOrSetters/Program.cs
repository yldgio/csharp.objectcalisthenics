using System.Linq;
namespace Bad
{
    public class Counter
    {
        public Counter(int initialValue = 0)
        {
            this._value = initialValue;
        }
        private int _value;
        //the same as 
        //public int Value{ get; set; }
        public void SetValue(int value)
        {
            this._value = value;
        }
        public int GetValue()
        {
            return this._value;
        }
    }

}

namespace Better
{
    public class Counter
    {
        private int _value;

        public Counter(int initialValue = 0)
        {
            this._value = initialValue;
        }

        public void Increment(int increment = 1)
        {
            _value += increment;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        /**
         *  follow the "Tell, don't ask" principle:
         *  
         *      Objects encapsulate state. Don’t break that encapsulation.
         *      The idea of Tell, Don’t Ask, is that objects should take responsibility for their state, 
         *      and should not allow other objects to bypass encapsulation and mess with the state. 
         *      For example, we might have a Better.Counter (not so bad) class 
         *      
         * **/


        var good = new Better.Counter(0);
        Enumerable
            .Range(1, 10)
            .ToList()
            .ForEach(i => good.Increment());

        /**
         *   Contrast that with the Bad.Counter class that leaks state
         * 
         * **/

        var bad = new Bad.Counter(0);
        for (int i = 0; i < 10; i++)
        {
            var val = bad.GetValue();
            val += 1;
            bad.SetValue(val);
        }

        /**
         * Examples:
         *  not good:
                if(current_user.admin)
                    puts current_user.admin_welcome_message
                else
                    puts current_user.user_welcome_message %>
         *  better:
                puts current_user.welcome_message
         * 
         * not so good:
         * 
            def check_for_overheating(system_monitor)
              if system_monitor.temperature > 100
                system_monitor.sound_alarms
              end
            end
         *  better:
                class SystemMonitor
                  def check_for_overheating
                    if temperature > 100
                      sound_alarms
                    end
                  end
                end         
                system_monitor.check_for_overheating
         
         * **/
    }

}
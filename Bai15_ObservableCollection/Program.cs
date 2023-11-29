using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Observable_Collection
{
    class Program
    {
        public static void Changed(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {   
                case NotifyCollectionChangedAction.Add:
                    foreach (string s in e.NewItems)
                    {
                        Console.WriteLine($"Add: {s}");
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach (string s in e.OldItems)
                    {
                        Console.WriteLine($"Remove: {s}");
                    }
                    break;
                case NotifyCollectionChangedAction.Replace:
                    Console.WriteLine($"Replace - {e.NewItems[0]}");
                    break;
                case NotifyCollectionChangedAction.Move:
                    break;
                case NotifyCollectionChangedAction.Reset:
                    Console.WriteLine("Reset!");
                    break;
                default:
                    break;
            }
        }
        static void Main(string[] argc)
        {
            ObservableCollection<string> obs = new ObservableCollection<string>();

            //Bat su kien thay doi va thuc hien cac hanh dong tuong ung
            obs.CollectionChanged += Changed;
            obs.Add("Dao Tien Dung");
            obs.Add("Pika pika");
            obs.Add("Sizuka");
            obs.Add("Nigizaka");
            obs.Remove("Sizuka");
            Console.WriteLine();

            Console.WriteLine("Cac phan tu trong danh sach obs:");
            foreach (var data in obs)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine();
            obs.Clear();
        }
    }
}
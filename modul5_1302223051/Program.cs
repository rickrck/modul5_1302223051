
using System.ComponentModel;

public class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;
    
    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }
    public void AddNewData(T newData)
    {
        storedData.Add(newData);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        if (storedData.Count == 0)
        {
            Console.WriteLine("Data Kosong");
            return;
        }

        int dataKe = 1;

        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine("Data " + dataKe + " berisi " + storedData[i] + " yang disimpan pada waktu UTC : " + inputDates[i]);
            dataKe++;
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        SimpleDataBase<int> database = new SimpleDataBase<int>();
        database.AddNewData(22);
        database.AddNewData(30);
        database.AddNewData(51);
        database.PrintAllData();
    }
}
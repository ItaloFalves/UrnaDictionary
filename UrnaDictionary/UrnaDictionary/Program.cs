
namespace UrnaDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o caminho do arquivo de candidatos: ");
            string path = Console.ReadLine();
            

            try
            {
                using(StreamReader sr = File.OpenText(path))
                {

                    Dictionary<string, int> candidatos = new Dictionary<string, int>();

                    while (!sr.EndOfStream) {

                        string[] line = sr.ReadLine().Split(',');
                        string key = line[0];
                        int val = int.Parse(line[1]);


                        if (candidatos.ContainsKey(key))
                        {
                            candidatos[key] += val;
                        }
                        else
                        {
                            candidatos[key] = val;
                        }
                    }

                    foreach(KeyValuePair<string, int> c in candidatos)
                    {
                        Console.WriteLine(c.Key + ": " + c.Value);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sacs.Tools
{
    public class CollaborationTools
    {

        public List<string> Files { get; private set; }
        public List<string> Messages { get; private set; }
        

        public CollaborationTools()
        {
            Files = new List<string>();
            Messages = new List<string>();
        }

        public void share_resource(string resourceName)
        {
            Console.WriteLine($"Resource '{resourceName}' shared successfully!");
        }

        public void create_share_file(String fileName)
        {
            Files.Add(fileName);
            Console.WriteLine($"File '{fileName}' created and added to shared resources.");
        }

        public void upload_share_file(string fileName)
        {
            if (!Files.Contains(fileName))
            {
                Files.Add(fileName);
                Console.WriteLine($"File '{fileName}' uploaded successfully!");
            }
            else
            {
                Console.WriteLine($"File '{fileName}' already exists in shared resources.");
            }
        }

    }
}

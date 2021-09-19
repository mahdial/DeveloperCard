namespace DevCard.Models
{
    public class Project
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Client { get; set; }
        public string IMG { get; set; }

        public Project(int id, string name, string description, string client, string img)
        {
            ID = id;
            Name = name;
            Description = description;
            Client = client;
            IMG = img;
        }

    }

}

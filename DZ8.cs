    public class Equipment
    {
        public string Type { get; set; }
        public Equipment(string Type)
        {
            Type = Type;
        }
    }    public class CarConfigurator
    {
        public string Model { get; private set; }
        private List<Equipment> additionalEquipment = new List<Equipment>();

        public void AddExtra(Equipment package)
        {
            additionalEquipment.Add(package);
        }

        public void Remove(Equipment package)
        {
            additionalEquipment.Remove(package);
        }
        public void Rollback(CarConfiguration configuration)
        {
            Model = configuration.GetModel();
            additionalEquipment.Clear();
            additionalEquipment.AddRange(configuration.GetPackages());
        }
        public CarConfiguration Store()
        {
            return new CarConfiguration(Model, additionalEquipment);
        }
    }

    public class CarConfiguration
    {
        private string model;
        private List<Equipment> additionalEquipment;
        public CarConfiguration(string model, List<Equipment> additionalEquipment)
        {
            this.model = model;
            this.additionalEquipment = new List<Equipment>(additionalEquipment);
        }

        public string GetModel()
        {
            return model;
        }

        public List<Equipment> GetPackages()
        {
            return additionalEquipment;
        }
    }
    public class ConfigurationManager
    {
        private List<CarConfiguration> configurations = new List<CarConfiguration>();

        public void AddConfiguration(CarConfiguration configuration)
        {
            configurations.Add(configuration);
        }

        public void DeleteConfiguration(CarConfiguration configuration)
        {
            configurations.Remove(configuration);
        }

        public CarConfiguration GetConfiguration(int index)
        {
            return configurations[index];
        }
    }


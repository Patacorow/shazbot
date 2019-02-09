namespace Shazbot.Audio
{
    public class AudioDeviceInfo
    {
        public string Name;

        public int Id;

        public AudioDeviceInfo(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

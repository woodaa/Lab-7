namespace Bits_Brewery
{
    public class HopType
    {
        public HopType() { }

        public HopType(int type, string name)
        {
            HopID = type;
            HopName = name;
        }

        public string HopName { get; set; }

        public int HopID { get; set; }

        public override string ToString()
        {
            return HopID + ", " + HopName;
                

            
        }
    }
}
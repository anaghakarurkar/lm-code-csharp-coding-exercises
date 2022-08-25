using System;
namespace Exercises
{
    public class Exercise003
    {
        public string[] IceCreamFlavours { get; set; }

        public Exercise003()
        {
            string[] flavors = { "Pistachio", "Raspberry Ripple", "Vanilla", "Mint Chocolate Chip", "Chocolate", "Mango Sorbet" };
            IceCreamFlavours = flavors;

        }

        public int IceCreamCode(string iceCreamFlavour)
        {
            int code = 0;

            for (int i = 0; i < IceCreamFlavours.Length; i++)
            {
                if (IceCreamFlavours[i].Equals(iceCreamFlavour))
                {
                    code = i;
                }
            }
            return code;

        }
    }
}


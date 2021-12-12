using System;

namespace c_sharp_odev_tip_donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            byte v_byte = 5;
            sbyte v_sbyte = 10;
            short v_short = 2;

            int v_int = v_byte + v_sbyte + v_short;
            Console.WriteLine("v_int: " + v_int);

            long v_long = v_int;
            Console.WriteLine("v_long: " + v_long);

            float v_float = v_long;
            Console.WriteLine("v_float: " + v_float);




            string v_string = "table";
            char v_char = 't';
            object v_object = v_string + v_char + v_int;
            Console.WriteLine("v_object: " + v_object);






            int v_int2 = 4;
            byte v_byte2 = (byte)v_int2;
            Console.WriteLine("v_byte2: " + v_byte2);

            float v_float3 = 6.2f;
            byte v_byte3 = (byte)v_float3;
            Console.WriteLine("v_byte3: " + v_byte3);

            int v_int4 = 8;
            string v_string4 = v_int4.ToString();
            Console.WriteLine("v_string4: " + v_string4);

            string v_string5 = 12.5f.ToString();
            Console.WriteLine("v_string5: " + v_string5);



            string v_string6 = "2", v_string7 = "12";
            int v_int6, v_int7;
            int v_intTotal;

            v_int6 = Convert.ToInt32(v_string6);
            v_int7 = Convert.ToInt32(v_string7);

            v_intTotal = v_int6 + v_int7;
            Console.WriteLine("v_intTotal: " + v_intTotal);





            string v_string8 = "10";
            string v_string9 = "10.25";
            int v_int8;
            double v_double9;

            v_int8 = Int32.Parse(v_string8);
            v_double9 = Double.Parse(v_string9);

            Console.WriteLine("v_int8: " + v_int8);
            Console.WriteLine("v_double9: " + v_double9);


            Console.WriteLine("Hello World!");
        }
    }
}

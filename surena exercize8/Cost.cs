﻿public class Cost
{
    
    public string vahed { get; set; }

    public double gheymat { get; set; }
    public double meghdar_rozane { get; set; }
    public override string ToString()
    {
        return $"vahed={vahed} gheymat={gheymat} meghdar _rozane={meghdar_rozane}";
    }


}
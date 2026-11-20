namespace SunamoGeo.Value;

public static class GeoCzechRegions
{
    private static List<GeoCzechRegion>? s_czechRegions;

    private static void Init()
    {
        s_czechRegions = new List<GeoCzechRegion>();
        s_czechRegions.Add(new GeoCzechRegion("A", "Hlavní město Praha", "PHA", "Prague"));
        s_czechRegions.Add(new GeoCzechRegion("S", "Středočeský", "STČ", "Prague"));
        s_czechRegions.Add(new GeoCzechRegion("C", "Jihočeský", "JHČ", "České Budějovice"));
        s_czechRegions.Add(new GeoCzechRegion("P", "Plzeňský", "PLK", "Plzeň"));
        s_czechRegions.Add(new GeoCzechRegion("K", "Karlovarský", "KVK", "Carlsbad"));
        s_czechRegions.Add(new GeoCzechRegion("U", "Ústecký", "ULK", "Ústí nad Labem"));
        s_czechRegions.Add(new GeoCzechRegion("L", "Liberecký", "LBK", "Liberec"));
        s_czechRegions.Add(new GeoCzechRegion("H", "Královéhradecký", "HKK", "Hradec Králové"));
        s_czechRegions.Add(new GeoCzechRegion("E", "Pardubický", "PAK", "Pardubice"));
        s_czechRegions.Add(new GeoCzechRegion("M", "Olomoucký", "OLK", "Olomouc"));
        s_czechRegions.Add(new GeoCzechRegion("T", "Moravskoslezský", "MSK", "Ostrava"));
        s_czechRegions.Add(new GeoCzechRegion("B", "Jihomoravský", "JHM", "Brno"));
        s_czechRegions.Add(new GeoCzechRegion("Z", "Zlínský", "ZLK", "Zlín"));
        s_czechRegions.Add(new GeoCzechRegion("J", "Kraj Vysočina", "VYS", "Jihlava"));
    }

    public static List<GeoCzechRegion> CzechRegions
    {
        get
        {
            if (s_czechRegions is null)
            {
                Init();
            }
            return s_czechRegions!;
        }
    }
}

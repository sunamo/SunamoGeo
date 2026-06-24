namespace SunamoGeo.Value;

public static class GeoCzechRegions
{
    private static List<GeoCzechRegion>? s_czechRegions;

    private static void Init()
    {
        s_czechRegions = new List<GeoCzechRegion>();
        s_czechRegions.Add(new GeoCzechRegion("A", "Hlavní město Praha", "PHA", Translate.FromKey(XlfKeys.Prague)));
        s_czechRegions.Add(new GeoCzechRegion("S", "Středočeský", "STČ", Translate.FromKey(XlfKeys.Prague)));
        s_czechRegions.Add(new GeoCzechRegion("C", "Jihočeský", "JHČ", "České Budějovice"));
        s_czechRegions.Add(new GeoCzechRegion("P", "Plzeňský", "PLK", "Plzeň"));
        s_czechRegions.Add(new GeoCzechRegion("K", "Karlovarský", "KVK", Translate.FromKey(XlfKeys.Carlsbad)));
        s_czechRegions.Add(new GeoCzechRegion("U", "Ústecký", "ULK", "Ústí nad Labem"));
        s_czechRegions.Add(new GeoCzechRegion("L", "Liberecký", "LBK", Translate.FromKey(XlfKeys.Liberec)));
        s_czechRegions.Add(new GeoCzechRegion("H", "Královéhradecký", "HKK", "Hradec Králové"));
        s_czechRegions.Add(new GeoCzechRegion("E", "Pardubický", "PAK", Translate.FromKey(XlfKeys.Pardubice)));
        s_czechRegions.Add(new GeoCzechRegion("M", "Olomoucký", "OLK", Translate.FromKey(XlfKeys.Olomouc)));
        s_czechRegions.Add(new GeoCzechRegion("T", "Moravskoslezský", "MSK", Translate.FromKey(XlfKeys.Ostrava)));
        s_czechRegions.Add(new GeoCzechRegion("B", "Jihomoravský", "JHM", Translate.FromKey(XlfKeys.Brno)));
        s_czechRegions.Add(new GeoCzechRegion("Z", "Zlínský", "ZLK", "Zlín"));
        s_czechRegions.Add(new GeoCzechRegion("J", "Kraj Vysočina", "VYS", Translate.FromKey(XlfKeys.Jihlava)));
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

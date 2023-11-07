namespace __Entidades
{
    public static class _Configuration
    {
        public static string lenguageSelected;
        public static Dictionary<EPaths, string> paths;

        //public static string JSON_FILE_WORLD = "./DATA/world.json";
        //public static string JSON_FILE_ITEM = "./DATA/items.json";
        //private static string pathResources = "./DATA/Resources/";
        
        public static string JSON_FILE_WORLD = "../../../../__Entidades/DATA/world.json";
        public static string JSON_FILE_ITEM = "../../../../__Entidades/DATA/items.json";
        private static string pathResources = "../../../../__Entidades/DATA/Resources/";

        private static string Accessories = "Accessories/";
        private static string Armor = "Armor/";
        private static string Magic = "Magic/";
        private static string Melee = "Melee/";
        private static string OffHand = "OffHand/";
        private static string Ranged = "Ranged/";

        static _Configuration()
        {
            lenguageSelected = "EN-US"; //Lenguage Default

            paths = new Dictionary<EPaths, string>
            {
                { EPaths.Bag, $"{pathResources}{Accessories}Bag/" },
                { EPaths.Cape, $"{pathResources}{Accessories}Cape/" },
                { EPaths.ClothArmor, $"{pathResources}{Armor}ClothArmor/" },
                { EPaths.ClothHelmet, $"{pathResources}{Armor}ClothHelmet/" },
                { EPaths.ClothShoes, $"{pathResources}{Armor}ClothShoes/" },
                { EPaths.LeatherArmor, $"{pathResources}{Armor}LeatherArmor/" },
                { EPaths.LeatherHelmet, $"{pathResources}{Armor}LeatherHelmet/" },
                { EPaths.LeatherShoes, $"{pathResources}{Armor}LeatherShoes/" },
                { EPaths.PlateArmor, $"{pathResources}{Armor}PlateArmor/" },
                { EPaths.PlateHelmet, $"{pathResources}{Armor}PlateHelmet/" },
                { EPaths.PlateShoes, $"{pathResources}{Armor}PlateShoes/" },
                { EPaths.ArcaneStaff, $"{pathResources}{Magic}ArcaneStaff/" },
                { EPaths.CursedStaff, $"{pathResources}{Magic}CursedStaff/" },
                { EPaths.FireStaff, $"{pathResources}{Magic}FireStaff/" },
                { EPaths.FrostStaff, $"{pathResources}{Magic}FrostStaff/" },
                { EPaths.HolyStaff, $"{pathResources}{Magic}HolyStaff/" },
                { EPaths.NatureStaff, $"{pathResources}{Magic}NatureStaff/" },
                { EPaths.Axe, $"{pathResources}{Melee}Axe/" },
                { EPaths.Dagger, $"{pathResources}{Melee}Dagger/" },
                { EPaths.Hammer, $"{pathResources}{Melee}Hammer/" },
                { EPaths.Mace, $"{pathResources}{Melee}Mace/" },
                { EPaths.QuarterStaff, $"{pathResources}{Melee}QuarterStaff/" },
                { EPaths.Spear, $"{pathResources}{Melee}Spear/" },
                { EPaths.Sword, $"{pathResources}{Melee}Sword/" },
                { EPaths.WarGloves, $"{pathResources}{Melee}WarGloves/" },
                { EPaths.Book, $"{pathResources}{OffHand}Book/" },
                { EPaths.Horn, $"{pathResources}{OffHand}Horn/" },
                { EPaths.Orb, $"{pathResources}{OffHand}Orb/" },
                { EPaths.Shield, $"{pathResources}{OffHand}Shield/" },
                { EPaths.Torch, $"{pathResources}{OffHand}Torch/" },
                { EPaths.Totem, $"{pathResources}{OffHand}Totem/" },
                { EPaths.Bow, $"{pathResources}{Ranged}Bow/" },
                { EPaths.Crossbow, $"{pathResources}{Ranged}Crossbow/" },
            };

        }

        public static void SetLenguage(ELocalizedNames s)
        {
            switch (s)
            {
                case ELocalizedNames.Ingles:
                    lenguageSelected = "EN-US";
                    break;
                case ELocalizedNames.Aleman:
                    lenguageSelected = "DE-DE";
                    break;
                case ELocalizedNames.Frances:
                    lenguageSelected = "FR-FR";
                    break;
                case ELocalizedNames.Ruso:
                    lenguageSelected = "RU-RU";
                    break;
                case ELocalizedNames.Polaco:
                    lenguageSelected = "PL-PL";
                    break;
                case ELocalizedNames.Español:
                    lenguageSelected = "ES-ES";
                    break;
                case ELocalizedNames.Portugues:
                    lenguageSelected = "PT-BR";
                    break;
                case ELocalizedNames.Italiano:
                    lenguageSelected = "IT-IT";
                    break;
                case ELocalizedNames.ChinoChina:
                    lenguageSelected = "ZH-CN";
                    break;
                case ELocalizedNames.Coreano:
                    lenguageSelected = "KO-KR";
                    break;
                case ELocalizedNames.Japones:
                    lenguageSelected = "JA-JP";
                    break;
                case ELocalizedNames.ChinoTaiwan:
                    lenguageSelected = "ZH-TW";
                    break;
                case ELocalizedNames.Indonesio:
                    lenguageSelected = "ID-ID";
                    break;
            }
        }
    }
}
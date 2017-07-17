using System;

namespace CraftingApp.Models
{
    public class Item : BaseDataObject
    {
        string text = string.Empty;
        public string Text
        {
            get { return text; }
            set { SetProperty(ref text, value); }
        }

        string category = string.Empty;
        public string Category
        {
            get { return category; }
            set { SetProperty(ref category, value); }
        }

        string image = string.Empty;
        public string Image
        {
            get { return image; }
            set { SetProperty(ref image, value); }
        }

        string icon = string.Empty;
        public string Icon
        {
            get { return icon; }
            set { SetProperty(ref icon, value); }
        }

        string weight = string.Empty;
        public string Weight
        {
            get { return weight; }
            set { SetProperty(ref weight, value); }
        }

        string destinyBoard = string.Empty;
        public string DestinyBoard
        {
            get { return destinyBoard; }
            set { SetProperty(ref destinyBoard, value); }
        }

        string production = string.Empty;
        public string Production
        {
            get { return production; }
            set { SetProperty(ref production, value); }
        }

        string description = string.Empty;
        public string Description
        {
            get { return description; }
            set { SetProperty(ref description, value); }
        }

        string tier = string.Empty;
        public string Tier
        {
            get { return tier; }
            set { SetProperty(ref tier, value); }
        }

        string[] tiers = new string[7];
        public string[] Tiers
        {
            get { return tiers; }
            set { SetProperty(ref tiers, value); }
        }

        string[] materials = new string[7];
        public string[] Materials
        {
            get { return materials; }
            set { SetProperty(ref materials, value); }
        }

        string specialMaterial = string.Empty;
        public string SpecialMaterial
        {
            get { return specialMaterial; }
            set { SetProperty(ref specialMaterial, value); }
        }

        string favoriteFood = string.Empty;
        public string FavoriteFood
        {
            get { return favoriteFood; }
            set { SetProperty(ref favoriteFood, value); }
        }

    }
}

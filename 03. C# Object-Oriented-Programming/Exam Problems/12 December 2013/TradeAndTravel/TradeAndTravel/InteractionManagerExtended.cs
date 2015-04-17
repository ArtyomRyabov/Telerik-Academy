namespace TradeAndTravel
{
    using System.Linq;

    public class InteractionManagerExtended : InteractionManager
    {
        protected override Person CreatePerson(string personTypeString, string personNameString, Location personLocation)
        {
            switch (personTypeString)
            {
                case "merchant":
                    return new Merchant(personNameString, personLocation);
                default:
                    return base.CreatePerson(personTypeString, personNameString, personLocation);
            }
        }

        protected override Item CreateItem(string itemTypeString, string itemNameString, Location itemLocation, Item item)
        {
            switch (itemTypeString)
            {
                case "weapon":
                    return new Weapon(itemNameString, itemLocation);
                case "wood":
                    return new Wood(itemNameString, itemLocation);
                case "iron":
                    return new Iron(itemNameString, itemLocation);
                default:
                    return base.CreateItem(itemTypeString, itemNameString, itemLocation, item);
            }
        }

        protected override Location CreateLocation(string locationTypeString, string locationName)
        {
            switch (locationTypeString)
            {
                case "mine":
                    return new Mine(locationName);
                case "forest":
                    return new Forest(locationName);
                default:
                    return base.CreateLocation(locationTypeString, locationName);
            }
        }

        protected override void HandlePersonCommand(string[] commandWords, Person actor)
        {
            switch (commandWords[1])
            {
                case "gather":
                    this.HandleGatherInteraction(actor, commandWords[2]);
                    break;
                case "craft":
                    this.HandleCraftInteraction(actor, commandWords[2], commandWords[3]);
                    break;
                default:
                    base.HandlePersonCommand(commandWords, actor);
                    break;
            }
        }

        private void HandleCraftInteraction(Person actor, string itemType, string itemName)
        {
            switch (itemType)
            {
                case "armor":
                    this.HandelArmorCrafting(actor, itemName);
                    break;
                case "weapon":
                    this.HandelWeaponCrafting(actor, itemName);
                    break;
            }
        }

        private void HandelWeaponCrafting(Person actor, string itemName)
        {
            if (actor.ListInventory().Any(item => item.ItemType == ItemType.Iron) 
                && actor.ListInventory().Any(item => item.ItemType == ItemType.Wood))
            {
                this.AddToPerson(actor, new Weapon(itemName));
            }
        }

        private void HandelArmorCrafting(Person actor, string itemName)
        {
            if (actor.ListInventory().Any(item => item.ItemType == ItemType.Iron))
            {
                this.AddToPerson(actor, new Armor(itemName));
            }
        }

        private void HandleGatherInteraction(Person actor, string itemToAdd)
        {
            if (actor.Location is IGatheringLocation)
            {
                var gatheringLocation = actor.Location as IGatheringLocation;

                if (actor.ListInventory().Any(item => item.ItemType == gatheringLocation.RequiredItem))
                {
                    this.AddToPerson(actor, gatheringLocation.ProduceItem(itemToAdd));
                }
            }
        }
    }
}
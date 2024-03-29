using Mono.TextTemplating;

namespace Characterlist.Models
{
    public enum Weapons
    {
        Sword,
        Axe,
        Crossbow,
        Staff,
        Dagger,
        Greatsword,
        GreatMace,
        spear,
    }


    public class CharacterlistWeapon
    {
        public required string Name { get; set; }
        public Weapons WeaponType { get; set; }
        public int Damage { get; set; }
        public int CritDamage { get; set; }
    }

    public interface IWeapon
    {
        int Damage { get; }
        int CritDamage { get; }
    }

    public class Weapon : IWeapon
    {
        public int Damage { get; private set; }

        public int CritDamage => throw new NotImplementedException();


    }

    public class Sword : IWeapon
    {
        public int Damage = 5;

        public int CritDamage = 8;

        int IWeapon.Damage => throw new NotImplementedException();

        int IWeapon.CritDamage => throw new NotImplementedException();
    }

    public class Axe : IWeapon
    {
        public int Damage = 7;

        public int CritDamage = 10;

        int IWeapon.Damage => throw new NotImplementedException();

        int IWeapon.CritDamage => throw new NotImplementedException();
    }

    public class Crossbow : IWeapon
    {
        public int Damage = 5;

        public int CritDamage = 8;

        int IWeapon.Damage => throw new NotImplementedException();

        int IWeapon.CritDamage => throw new NotImplementedException();
    }

    public class Staff : IWeapon
    {
        public int Damage = 7; 
        public int CritDamage = 10;

        int IWeapon.Damage => throw new NotImplementedException();

        int IWeapon.CritDamage => throw new NotImplementedException();
    }

    public class Dagger : IWeapon
    {
        public int Damage = 3;
        public int CritDamage = 7;

        int IWeapon.Damage => throw new NotImplementedException();

        int IWeapon.CritDamage => throw new NotImplementedException();
    }

    public class Greatsword : IWeapon
    {
        public int Damage = 10;
        public int CritDamage = 16;

        int IWeapon.Damage => throw new NotImplementedException();

        int IWeapon.CritDamage => throw new NotImplementedException();
    }

    public class Greatmace : IWeapon
    {
        public int Damage = 12;
        public int CritDamage = 18;

        int IWeapon.Damage => throw new NotImplementedException();

        int IWeapon.CritDamage => throw new NotImplementedException();
    }

    public class Spear : IWeapon
    {
        public int Damage = 8;
        public int CritDamage = 13;

        int IWeapon.Damage => throw new NotImplementedException();

        int IWeapon.CritDamage => throw new NotImplementedException();
    }
}

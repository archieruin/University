using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    abstract class Weapon
    {
        protected string Name { get; set; }
        protected string OwnerName { get; set; }
        protected double Damage { get; set; }

        protected Weapon(string name, string ownerName, double damage)
        {
            Name = name;
            OwnerName = ownerName;
            Damage = damage;
        }

        public abstract string Info();

        public abstract string MakeDamage(string To);
    }

    class Knife : Weapon
    {
        public double Length { get; }

        public Knife(string name, string ownerName, double damage, double length) : base(name, ownerName, damage)
        {
            Length = length;
        }

        public override string Info()
        {
            return $"Название: {Name}, Владелец: {OwnerName}, Урон: {Damage}, Длина: {Length}";
        }

        public override string MakeDamage(string To)
        {
            return $"{OwnerName} ударил {Name} {To} и нанес(ла) {Damage} урона.";
        }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var myKnife = new Knife("Керамбит", "Артур", 12.4, 25.0);
            Console.WriteLine(myKnife.Info());
            Console.WriteLine(myKnife.MakeDamage("Andry"));
        }
    }
}

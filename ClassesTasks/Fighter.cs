using System;

namespace ClassesTasks
{
    public class Fighter
    {
        public string Name;
        public int Health, DamagePerAttack;

        public Fighter(string name, int health, int damagePerAttack)
        {
            this.Name = name;
            this.Health = health;
            this.DamagePerAttack = damagePerAttack;
        }

        public static string DeclareWinner(Fighter player1, Fighter player2, string firstAttacker)
        {
            Fighter fighter1 = firstAttacker == player1.Name ? player1 : player2;
            Fighter fighter2 = firstAttacker == player2.Name ? player2 : player1;
            
            while (player1.Health > 0 && player2.Health > 0)
            {
                player2.Health = player2.Health - player1.DamagePerAttack;
                if (player2.Health <= 0) return player1.Name;
                player1.Health = player1.Health - player2.DamagePerAttack;
                if (player1.Health <= 0) return player2.Name;
            }
            
            return firstAttacker;

            // int FirstFighter = (fighter1.Health - 1) / fighter2.DamagePerAttack;
            // int SecondFighter = (fighter2.Health - 1) / fighter1.DamagePerAttack;
            //
            // return FirstFighter > SecondFighter ? fighter1.Name : SecondFighter > FirstFighter ? fighter2.Name : firstAttacker;
        }
    }
}
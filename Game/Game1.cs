using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SilverDream.Battles;
using SilverDream.Battles.Skills;
using SilverDream.Battles.Costs;
using SilverDream.Battles.Characters;
using SilverDream.Battles.SkillEffects;



namespace SilverDream
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            Stats stats1 = new Stats(20, 20, 2, 1243, 1, 2, 3, 2, 2);
            SkillList skills1 = new SkillList(4);
            skills1.add(new MagicSkill("Whipshot", new SpCost(3), 4));
            PlayerCharacter p1 = new PlayerCharacter("James", stats1, skills1);


            Stats stats2 = new Stats(20, 20, 2, 1243, 1, 2, 3, 2, 2);
            SkillList skills2 = new SkillList(4);
            skills2.add(new MagicSkill("Flail", new SpCost(3), 4));
            PlayerCharacter p2 = new PlayerCharacter("Jordan", stats2, skills2);


            List<Character> allies = new List<Character>();
            allies.Add(p1);

            List<Character> enemies = new List<Character>();
            enemies.Add(p2);

            Battle b = new Battle(allies, enemies);
            Console.Write(b.ToString());

            b.UseSkill(p1.SkillList.GetSkillAt(0), p1, p2);
            Console.Write(b.ToString());

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();


            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);


            base.Draw(gameTime);
        }
    }
}

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace MoneyTroughPet.Items
{
	public class MoneyTroughPet : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName and Tooltip are automatically set from the .lang files, but below is how it is done normally.
			DisplayName.SetDefault("Money Trough Pet");
			Tooltip.SetDefault("Summons the Money Trough as a pet");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.MoneyTrough);
			item.shoot = (ProjectileID.FlyingPiggyBank);
			item.buffType = BuffType<Buffs.TheMoneyTroughPetBuff>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MoneyTrough);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PiggyBank);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.MoneyTrough);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MoneyTrough);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.PiggyBank);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PiggyBank);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.MoneyTrough);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.PiggyBank);
			recipe.AddRecipe();

		}

		public override void UseStyle(Player player)
		{
			if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
			{
				player.AddBuff(item.buffType, 3600, true);
			}
		}
	}
}
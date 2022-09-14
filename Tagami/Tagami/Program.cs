using Tagami;

Bord bord=new Bord();
Stone Player_1 = new Stone("○");
Stone Player_2 = new Stone("☓");

bord.Bord_Init();
bord.Bord_Draw();
while (true)
{
	Player_1.XY_Input();
	bord.Bord_input(Player_1.pos.x, Player_1.pos.y, Player_1.icon);
	bord.Bord_Draw();
	Player_2.XY_Input();
	bord.Bord_input(Player_2.pos.x, Player_2.pos.y, Player_2.icon);
	bord.Bord_Draw();
}
using Tagami;

Bord bord=new Bord();
Stone Player_1 = new Stone("a");
Stone Player_2 = new Stone("b");
bool isWin=false;
bord.Bord_Init();
bord.Bord_Draw();
while (!isWin)
{
	Console.WriteLine(Player_1.icon + "の番です");
	Player_1.XY_Input();
	bord.Bord_input(Player_1.pos.x, Player_1.pos.y, Player_1.icon);
	bord.Bord_Draw();
	isWin=bord.Win_Output();
	Console.WriteLine(Player_2.icon + "の番です");
	Player_2.XY_Input();
	bord.Bord_input(Player_2.pos.x, Player_2.pos.y, Player_2.icon);
	bord.Bord_Draw();
	isWin=bord.Win_Output();
}
Console.WriteLine(" ");
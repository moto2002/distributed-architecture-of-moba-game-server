namespace Moba.Utility
{
	/// <summary>
	/// 这个类提供了Resources下文件名和路径字典访问方式，同名资源可能引起bug
	/// </summary>
	public class AssetConstUtil : ReadyGamerOne.MemorySystem.AssetConstUtil<AssetConstUtil>
	{
		private System.Collections.Generic.Dictionary<string,string> nameToPath 
			= new System.Collections.Generic.Dictionary<string,string>{
					{ @"LightRing" , @"ClassEffect\other\LightRing" },
					{ @"Aige_5" , @"ClassMaster\Aige_5" },
					{ @"Beinuyideyuanren_5" , @"ClassMaster\Beinuyideyuanren_5" },
					{ @"Bianfu_5" , @"ClassMaster\Bianfu_5" },
					{ @"Chengjiezhe_5" , @"ClassMaster\Chengjiezhe_5" },
					{ @"Dianmanren_5" , @"ClassMaster\Dianmanren_5" },
					{ @"Dongfashi_5" , @"ClassMaster\Dongfashi_5" },
					{ @"Feilong_5" , @"ClassMaster\Feilong_5" },
					{ @"Fushilong_5" , @"ClassMaster\Fushilong_5" },
					{ @"Gongchengche_5" , @"ClassMaster\Gongchengche_5" },
					{ @"Haiqishi_5" , @"ClassMaster\Haiqishi_5" },
					{ @"Hanhui_5" , @"ClassMaster\Hanhui_5" },
					{ @"Heimolv_5" , @"ClassMaster\Heimolv_5" },
					{ @"Hunmo_5" , @"ClassMaster\Hunmo_5" },
					{ @"Jiachong_5" , @"ClassMaster\Jiachong_5" },
					{ @"Jialong_5" , @"ClassMaster\Jialong_5" },
					{ @"Jinglingnan_5" , @"ClassMaster\Jinglingnan_5" },
					{ @"Jinglingnan_6" , @"ClassMaster\Jinglingnan_6" },
					{ @"Jinglingnv_5" , @"ClassMaster\Jinglingnv_5" },
					{ @"Jinglingnv_6" , @"ClassMaster\Jinglingnv_6" },
					{ @"jlxb_jz_5" , @"ClassMaster\jlxb_jz_5" },
					{ @"jlxb_jz_6" , @"ClassMaster\jlxb_jz_6" },
					{ @"jlxb_yc_5" , @"ClassMaster\jlxb_yc_5" },
					{ @"jlxb_yc_6" , @"ClassMaster\jlxb_yc_6" },
					{ @"Juren_5" , @"ClassMaster\Juren_5" },
					{ @"Kuishe_5" , @"ClassMaster\Kuishe_5" },
					{ @"Kulouqishi_5" , @"ClassMaster\Kulouqishi_5" },
					{ @"Linghunzhanche_5" , @"ClassMaster\Linghunzhanche_5" },
					{ @"Linghunzhanche_a5" , @"ClassMaster\Linghunzhanche_a5" },
					{ @"Lisa_5" , @"ClassMaster\Lisa_5" },
					{ @"Mainu_5" , @"ClassMaster\Mainu_5" },
					{ @"Nvyao_5" , @"ClassMaster\Nvyao_5" },
					{ @"Pangge_5" , @"ClassMaster\Pangge_5" },
					{ @"Paotai" , @"ClassMaster\Paotai" },
					{ @"Renma_5" , @"ClassMaster\Renma_5" },
					{ @"Saqier_5" , @"ClassMaster\Saqier_5" },
					{ @"Shihunzhe_5" , @"ClassMaster\Shihunzhe_5" },
					{ @"Taiyushen_5" , @"ClassMaster\Taiyushen_5" },
					{ @"Tanshigui_5" , @"ClassMaster\Tanshigui_5" },
					{ @"Wenyi_5" , @"ClassMaster\Wenyi_5" },
					{ @"wlxb_jz_5" , @"ClassMaster\wlxb_jz_5" },
					{ @"wlxb_jz_6" , @"ClassMaster\wlxb_jz_6" },
					{ @"wlxb_yc_5" , @"ClassMaster\wlxb_yc_5" },
					{ @"wlxb_yc_6" , @"ClassMaster\wlxb_yc_6" },
					{ @"Xiong_5" , @"ClassMaster\Xiong_5" },
					{ @"Xiyiren_5" , @"ClassMaster\Xiyiren_5" },
					{ @"Yanmo_5sp" , @"ClassMaster\Yanmo_5sp" },
					{ @"Yelang_5" , @"ClassMaster\Yelang_5" },
					{ @"Yiliaoyuanren_5" , @"ClassMaster\Yiliaoyuanren_5" },
					{ @"Yuren_5" , @"ClassMaster\Yuren_5" },
					{ @"Zhadanren_5" , @"ClassMaster\Zhadanren_5" },
					{ @"Zhizhu_5" , @"ClassMaster\Zhizhu_5" },
					{ @"BattlePanel" , @"ClassPanel\BattlePanel" },
					{ @"ChatPanel" , @"ClassPanel\ChatPanel" },
					{ @"HomePanel" , @"ClassPanel\HomePanel" },
					{ @"LoadingPanel" , @"ClassPanel\LoadingPanel" },
					{ @"LoginPanel" , @"ClassPanel\LoginPanel" },
					{ @"Avator_0" , @"ClassSprite\roundheader\Avator_0" },
					{ @"Avator_1" , @"ClassSprite\roundheader\Avator_1" },
					{ @"Avator_2" , @"ClassSprite\roundheader\Avator_2" },
					{ @"Avator_3" , @"ClassSprite\roundheader\Avator_3" },
					{ @"Avator_4" , @"ClassSprite\roundheader\Avator_4" },
					{ @"Avator_5" , @"ClassSprite\roundheader\Avator_5" },
					{ @"Avator_6" , @"ClassSprite\roundheader\Avator_6" },
					{ @"Avator_7" , @"ClassSprite\roundheader\Avator_7" },
					{ @"Avator_8" , @"ClassSprite\roundheader\Avator_8" },
					{ @"LoginBonues" , @"ClassUi\LoginBonues" },
					{ @"MatchDlgUi" , @"ClassUi\MatchDlgUi" },
					{ @"PlayerInfo" , @"ClassUi\PlayerInfo" },
					{ @"SelfUi" , @"ClassUi\SelfUi" },
					{ @"StatusUi" , @"ClassUi\StatusUi" },
					{ @"TalkUi" , @"ClassUi\TalkUi" },
					{ @"UserInfoDlg" , @"ClassUi\UserInfoDlg" },
					{ @"TimeLine" , @"TimeLine" },
				};
		public override System.Collections.Generic.Dictionary<string,string> NameToPath => nameToPath;
	}
}

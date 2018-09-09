//==============================================================================
//  MGame_ChessConfig
//==============================================================================

class MGame_ChessConfig extends MGame_Config
    dependsOn()
  ;

  const MGAME_CHESS_CONFIG_COUNT =  3;
  const MGAME_CHESS_CONFIG_TIME =  2;
  const MGAME_CHESS_CONFIG_PLAYER2_COLOR =  1;
  const MGAME_CHESS_CONFIG_PLAYER1_COLOR =  0;

  function Initialize() {
    Super.Initialize();                                                         //0000 : 1C 48 01 19 11 16 
    SetConfigCount(3);                                                          //0006 : 1B 90 6E 00 00 2C 03 16 
    SetConfig(2,0);                                                             //000E : 1B 79 6E 00 00 2C 02 25 16 
    SetConfig(0,0);                                                             //0017 : 1B 79 6E 00 00 25 25 16 
    SetConfig(1,1);                                                             //001F : 1B 79 6E 00 00 26 26 16 
    //1C 48 01 19 11 16 1B 90 6E 00 00 2C 03 16 1B 79 6E 00 00 2C 02 25 16 1B 79 6E 00 00 25 25 16 1B 
    //79 6E 00 00 26 26 16 04 0B 47 
  }



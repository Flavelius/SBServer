//==============================================================================
//  CCom_Unstuck
//==============================================================================

class CCom_Unstuck extends Game_ConsoleCommand
    native
    dependsOn()
  ;


  native function bool Execute(Game_Pawn aPawn,array<string> Params,Game_Pawn aTarget);



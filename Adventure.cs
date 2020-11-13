using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Serialization;
using System.Media;
using static System.Console;

namespace Adventure_Game
{
    class Adventure
    {

        public Adventure(string characterName)
        {
            chapter1(characterName); //Sends in the character's name from startup's AskForName method to this Method
        }
        //public string List<Item> Inventory = new List<Item>();

        public void chapter1(string characterName)
        {
            ForegroundColor = ConsoleColor.Gray;
            WriteLine(@"   _____ _                 _              __ 
  / ____| |               | |            /_ |
 | |    | |__   __ _ _ __ | |_ ___ _ __   | |
 | |    | '_ \ / _` | '_ \| __/ _ \ '__|  | |
 | |____| | | | (_| | |_) | ||  __/ |     | |
  \_____|_| |_|\__,_| .__/ \__\___|_|     |_|
                    | |                      
                    |_|                      ");
            ReadKey();
            Clear();
            WriteLine($"{characterName} browses the internet and sees an update notification. \nBut their computer now shows nothing but a screen full of static!");
            ReadKey();
            WriteLine("You see an image of a girl on the screen. Who is she...?");
            ReadKey();
            WriteLine(@"                                       _                             
                             _.      .' `-.                          
                           .'  `-.::/_.    `.                        
                          /   _.   .'        \                       
                        .' .'\  `./      `.   \                      
                     .-'  /   '.    .'.    \   ;                     
                  .-'  .-'      \ .'   \    .  |                     
               .-'   .'      .-._'_.-.  \    . :                     
              /     /     .-'    '    `. '.     \         :          
             :     :     /              `. '.    `.      /|          
              \    |    /                /`. '-.   `-._.' ;          
               ;   |  .;                :   \   '-.      /           
       `.     /    :.'/      _       _   \   \     \  _.'            
        \`._.'    // :    .s$$P     T$$s. '.  \     ; \              
         `._.   .':  |  .dP'           `Tb. \  \    |  `.            
            /  /  |  | dP  .-.       .-.  Tb ;  .   |    `-.         
        `_.'  :   |  |'   'd$b       d$b`   `|` |   |     | `.       
         '.   |   |  :   ':$$$       $$$:`   '\ |   '    /|   \      
           `-'|   |  :` ; |T$P       T$P| : '  :|  /   .' ;    ;     
              :   :   \\`-:__.       .__:-'/ .' |.'\_.'  /     |     
              /\   \   .\        s        / :   /|      /      :     
             .  '.  \  | \     .___.     /   \ : |    .'      /      
           .'     \  'X   '.           .'\    '.\|\.-'      .'       
         .'        \   '.  |`.       .'|  :      `.'.    .-'|        
        /           '    '-:  `-._.-'; |   `.      \ '-.'   ;        
       :             '      \       /  |--.._J.-.    '.  './    -.   
        \             \      \     :         / . `-.  \   '.     \`. 
         `.      .     ;      ;             /   `-. `-.;    \     : .
           `-._.'      |      |          __/          /|     \._.'  '
");
            ReadKey();
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine($"{characterName}... Please help me.");
            ReadKey();
            WriteLine($"Th3@e's a m0437ST3R cA(%ED Skieth");
            ReadKey();
            WriteLine($"Please... y0U H@^7 T+ J#~P m3");
            ReadKey();
            ForegroundColor = ConsoleColor.Gray;
            WriteLine(@"MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMW▒████████▓|MMM▒▒▒▒▒▒███████████████▒MMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM▒████████████████████████████████████▓▒▒MMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMM$███████████████████████████████████████▒▒▒MMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMÑ███████████████████████████████████▒▒▒▒ÑMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMM▒██████████████████████████████████▒MMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMM███████████████████████████████████▒▒▒MMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMÑ████████████████████████████████████▒▒▒▒▒▒|MMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMÑ$███████████████████████████████████▒▒▒▒▒MMMMMMMMM
MMMMMMMMMMM$██▒|MMMMMMMMMMMMMM█████████████████████████████████████▒▒▒▒MMMMMMMMM
MMMMM▒MMMMMÑ██████▓▓▓▒▒MMMMM▓█████████████████████████████████████▒▒▒▒|MMMMMMMMM
MMMMMMMMMMM▓████████████▓▄▄████████████████████████████████████████▒▒|MMMMMMMMMM
MMMMMMMMMW██████▒▒▒MM@█████████████████████████████████████████████▒▒▒▒▒MMMMMMMM
MMMMMMMMM$██▒MM$████████████ÑÑMM@███████████████████████████████████▒▒▒▒▒MMMMMMM
MMMMMMMMM▒███▓▓██████ÑÑÑ██▒|MMMMM██████████████████████████████████▒▒▒▒▒MMMMMMMM
MMMMMMM▓████████ÑÑ██▒|M▓██▒M▒MMMMÑ$██████████████████████████████M▒▒▒▒▒|MMMMMMMM
MMMMMM███████▒▒▒MM@██████▒MMMMMMMMM$████████████████████████████|MMÑÑM▒|▒MMMMMMM
MMMMMMMÑÑÑÑÑÑ███████████|MMMMMMMMMMMÑ█████████████████████████▒▒|MMMMMMMÑMMMMMMM
MMMMMMMMMMMMMMÑÑÑÑÑÑ$██▒|MMMM▒MMMMMMMMÑ█████████████████████▒▒▒▒▒|MMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMÑMÑMMMMMMMMM▒MMMMMMÑÑ████████████████▄▒MÑÑM▒MMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM$███████████████▒MMMMMMMMMMMMMMMMMMM");
            ReadKey();
            ForegroundColor = ConsoleColor.DarkCyan;
            WriteLine("!!!\nDon't tell me this is...!");
            ReadKey();
            ForegroundColor = ConsoleColor.Gray;
            WriteLine($"{characterName} blacks out and feel like they're falling in an endless pit.");
            ForegroundColor = ConsoleColor.DarkCyan;
            WriteLine("WHOAAAAAAAAAAAA!!");
            ReadKey();
            Clear();
            ForegroundColor = ConsoleColor.Gray;
            WriteLine($"THUD!\n{characterName} wakes up in an endless field of grid lines.");
            ForegroundColor = ConsoleColor.DarkCyan;
            WriteLine("W-Where am I?");
            ReadKey();
            ForegroundColor = ConsoleColor.Gray;
            WriteLine($"{characterName} sees wireframe-like buildings pop up from the ground and a 1:1 representation of their\nhometown appears right in front of their eyes!");
            ReadKey();
            WriteLine($"{characterName} feels lost and sees a stranger who looks just like a real person.");
            chapter1A(characterName);
            return;
        }

        public void chapter1A(string characterName) //Next chapter I should use arrays instead of if if else?
        {
            ForegroundColor = ConsoleColor.Gray;
            WriteLine($"{characterName} walks up to the stranger and asks them for directions.");
            ReadKey();
            ForegroundColor = ConsoleColor.DarkCyan;
            WriteLine("Um, excuse me, do you know where I am--");
            ReadKey();
            ForegroundColor = ConsoleColor.Gray;
            WriteLine("The stranger turns around and looks at you.");
            ReadKey();
            WriteLine(@"                      ______    __
                ___,---'......`-./  \--.
               /_/,.::::::::::::.`--/.:.\_
               '.'|:::::::::::::::::::::..\
             .':| ;|::::::;::;::::::|.::::.\
             ':|| `|;|::|; __...:::::|.::::.\
            /.'::\_______.::::::::::::|.::::.|
           ..|.|:::::::::::::::::::::::|.:::.|
           |.|:.|:|.:|:|\:|.|:|.:|:::::|.::::.|
          .'.::.||:|\:.|.:|: ::\\.:|::::|.:::.|
          |.::::|:..||_||`-|\--;`\--:|:::.:::.|
          |.:::::,--''___      ___  |-.:::.::.|
          |.:|:::.\  ` YD     'lYD` |\|:::||:.'
          |.::::::.|   `P      `P', |/|:::'|:|
          `.|.::::.|  --- _    ---  | /::|:'.'
           \|\.:::.`      \'        |';;;||;|
            `|;_|::_\               ':.::.::'
                \;/.=.     o      _/::::::||
                 | -.'\_   --    / .\|:|:|'
              _._|   `'-`-.__,--'  |'\---'-.-.
             /.   `-._    \ \     /  |. |  |\ `.
            /  \  |. .`.,  ,|   _/   /..| :|    \
           /    \ |.. ./   .'.-'    / ..| ', '   :
          :       | ../    |-.     /|.. | :      |
          |       |..|    |/Dn\  .' |...| |      |
          |       |./\    ; lH \'   |. .| '       |
          /       |/  `- '' lH      |..../        |");
            ReadKey();
            ForegroundColor = ConsoleColor.Green;
            WriteLine("Huh-wha? Oh hi. I can already read your mind. You need to head to the Kernel.\nBut first, here's a map. Take it.");
            ForegroundColor = ConsoleColor.Gray;
            WriteLine($"{characterName} recived a map of the Digital world!");
            //inventory.add
            //todo: Make an Item class and have that class keep track of what items are obtained.
            WriteLine($"{characterName} reads the map.");
            ReadKey();
            WriteLine(@"
____________________________________________________________________
|                                                                   |
|                                                      - The Kernel |
|                                                     /       |     |
|                                                    /        ?     |
|                         Corrupted Caverns- - - - -/         ?     |
|                        /               \                    ?     |
|                       /                 \                   |     |
|                      /                   \- - - - - Net Slum      |
|                     /                                             |
|     Town - - - - - -                                              |
| (Your Location) - - - - - - - - - Encrypted Lake                  |
|         |                                                         |
|         |                                                         |
|         |                                                         |
|         |                                                         |
|         |                                                         |
|        Scenic Park - - - - - - - - - Abyss of Zeroes              |
|                                                                   |
|                                                                   |
|___________________________________________________________________|
");
            TravelMenu1:
            ForegroundColor = ConsoleColor.DarkCyan;
            WriteLine("Where should I go next?");
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("Please enter a selection:");
            ForegroundColor = ConsoleColor.Gray;
            WriteLine("1.) Corrupted Caverns\n2.) Encrypted Lake\n3.) Scenic Park.");
            //The player needs to go to the Scenic Park ->
            //Abyss of Zeroes -> Encrypted Lake -> CC -> Net Slum -> The Kernel.
            ConsoleKeyInfo info = ReadKey(true);
            if (info.Key == ConsoleKey.D1)
            {
                WriteLine($"{characterName} decided to go to the Corrupted Caverns.");
                ReadLine();
                //If the player doesnt have the Antivirus Shield, they cant enter.
                WriteLine($"{characterName} enters a cave and there's geyzers spewing out purple static!");
                ForegroundColor = ConsoleColor.DarkCyan;
                //This is TEMPORARY, will code this in another way once I get the item class implemented.
                WriteLine("Damn! I can't go in there!");
                ReadKey();
                ForegroundColor = ConsoleColor.Gray;
                WriteLine($"{characterName} left the Corrupted Caverns.");
                ForegroundColor = ConsoleColor.Yellow;
                WriteLine("You do not have the Antivirus Shield yet.");
                ReadKey();
                goto TravelMenu1;
            }

            if (info.Key == ConsoleKey.D2)
            {
                WriteLine($"{characterName} decided to go to the Encrypted Lake.");
                ReadKey();
                //If the player doesnt have the Crypto-Key, they can't enter.
                ForegroundColor = ConsoleColor.DarkCyan;
                WriteLine("This seems to be an ordinary lake. Nothing unusual here. The breeze is nice though.");
                ReadKey();
                goto TravelMenu1;
            }
            if (info.Key == ConsoleKey.D3) //First time player goes here first
            {
                WriteLine($"{characterName} decided to go to the Scenic Park.");
                ReadLine();
                Chapter1_ScenicPark1(characterName);
                return;
            }
            while (info.Key != ConsoleKey.D1 && info.Key != ConsoleKey.D2 && info.Key != ConsoleKey.D3)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"You cannot escape, {characterName}. Please make a valid selection.");
                ForegroundColor = ConsoleColor.Gray;
                goto TravelMenu1; //Learned this from https://kodify.net/csharp/loop/exit-loop/#exit-a-loop-with-cs-goto-statement
            }
        }
        public void Chapter1_ScenicPark1(string characterName)
        {
            Clear();
            WriteLine($"{characterName} sees a stray kitten at the park. It's looking at them with cute eyes,\nand seems to be holding on to something");
            ReadLine();
            WriteLine(@"       ,
       \`-._           __
        \\  `-..____,.'  `.
         :`.         /    \`.
         :  )       :      : \
          ;'        '   ;  |  :
          )..      .. .:.`.;  :
         /::...  .:::...   ` ;
         ; _ '    __        /:\
         `:o>   /\o_>      ;:. `.
        `-`.__ ;   __..--- /:.   \
        === \_/   ;=====_.':.     ;
         ,/'`--'...`--....        ;
              ;                    ;
            .'                      ;
          .'                        ;
        .'     ..     ,      .       ;
       :       ::..  /      ;::.     |
      /      `.;::.  |       ;:..    ;
     :         |:.   :       ;:.    ;
     :         ::     ;:..   |.    ;
      :       :;      :::....|     |
      /\     ,/ \      ;:::::;     ;
    .:. \:..|    :     ; '.--|     ;
   ::.  :''  `-.,,;     ;'   ;     ;
.-'. _.'\      / `;      \,__:      \
`---'    `----'   ;      /    \,.,,,/
                   `----`              ");
            ForegroundColor = ConsoleColor.Green;
            WriteLine("Oh hewwo! Youw seem tow be wooking fow something uwu...\nI feew wike I know yu somewhewre.");
            ReadKey();
            WriteLine("What would you like to name the cat? Please type a name, then press [Enter] when finished:");
            string catName = ReadLine();
        DialogueSelect1:
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("What would you say?");
            ForegroundColor = ConsoleColor.Gray;
            WriteLine("1.) Awwe, a cute kitten!\n2.) Do you perhaps know about Skeith?\n3.) You look like my neighbor's pet--");
            ConsoleKeyInfo info = ReadKey(true);
            if (info.Key == ConsoleKey.D1)
            {
                ForegroundColor = ConsoleColor.DarkCyan;
                WriteLine("What a cute kitten!");
                ForegroundColor = ConsoleColor.Gray;
                WriteLine($"{characterName} proceeds to pet the kitten's head");
                ReadKey();
                ForegroundColor = ConsoleColor.Green;
                WriteLine("*gasp* !! T-Thank you! These pets remind me of someone I once knew...\nAnd since they remind me of someone from a different dimension, they told me to give you this.\nPlease, take it.");
                goto ItemGet1;
            }
            if (info.Key == ConsoleKey.D2)
            {
                //Dialogue
                ForegroundColor = ConsoleColor.DarkCyan;
                WriteLine("Do you perhaps know something about a creature named Skeith?");
                ReadKey();
                ForegroundColor = ConsoleColor.Green;
                WriteLine("Skeith... That name wings a bell, but I onwy vaguewy heard of howwor storwies about that.\nDid yuw see him?");
                ReadKey();
                ForegroundColor = ConsoleColor.DarkCyan;
                WriteLine("Yeah, before I got isekai'd into this world.");
                ReadKey();
                ForegroundColor = ConsoleColor.Green;
                WriteLine("What world? This IS the world uwu. Howw can youw get sucked intow\nsomething yow've alweady been wiving in?");
                ReadKey();
                ForegroundColor = ConsoleColor.DarkCyan;
                WriteLine("(Yeah, this guy doesn't get what happened to me.)");
                ReadKey();
                WriteLine($"Well, forget what I said, I need to look for him to get outta here.\nGot any clues, {catName}? Or should I say {catName}?");
                ReadKey();
                ForegroundColor = ConsoleColor.Green;
                WriteLine("I have something fow yew.");
                goto ItemGet1;
            }
            if (info.Key == ConsoleKey.D3)
            {
                //dialogue
                ForegroundColor = ConsoleColor.DarkCyan;
                WriteLine("You look like my neighbor's cat");
                ForegroundColor = ConsoleColor.Green;
                WriteLine("I dew? Well, I wiww take that as a compwiment! Here, take this.");
                goto ItemGet1;
            }
            while (info.Key != ConsoleKey.D1 && info.Key != ConsoleKey.D2 && info.Key != ConsoleKey.D3)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"You cannot escape, {characterName}. Please make a valid selection.");
                ForegroundColor = ConsoleColor.Gray;
                goto DialogueSelect1;
            }
        ItemGet1:
            ForegroundColor = ConsoleColor.Gray;
            WriteLine($"{characterName} recieved a Crypto-key!");
            ReadKey();
            ForegroundColor = ConsoleColor.Green;
            WriteLine("Here's a Crpto-key for yow to entew the Encwypted Wake.\nRight now it's not activated, so you need to head to the Abyss of Zewoes first.");
            ForegroundColor = ConsoleColor.DarkCyan;
            WriteLine("Thanks!");
            WriteLine("(Guess I'll head to the Abyss of Zeroes to get this thing setup...)");
            ReadKey();
            ForegroundColor = ConsoleColor.Gray;
            Chapter1_ABZ(characterName, catName);
            return;
        }

        public void Chapter1_ABZ(string characterName, string catName)
        {
            //Player goes here, scenario happens, after that start the Chapter2()
            WriteLine($"{characterName} heads to the Abyss of Zeroes.\nThey walk on the side of a huge beach, and suddenly the surroundings quickly turn into\nsome kind of ruins site!");
            ReadKey();
            WriteLine($"{characterName} proceeds to walk inside a ruins temple in front of them.");
            ReadKey();
            WriteLine($"It's dark, cold, and there's a couple torches lighting up the hall.\n{characterName} walks ahead slowly until they happen to see a mural of something...");
            ReadKey();
            ForegroundColor = ConsoleColor.DarkCyan;
            WriteLine("Huh, won't be surprised if this is some kind of scripture...");
            ReadKey();
            WriteLine("Who is this?");
            ReadKey();
            ForegroundColor = ConsoleColor.Gray;
            WriteLine(@"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&&@@@&& &@@@@@@@@@@@@@@@@@@@@@@@@@@@##&@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@/**//%&& .., **//&@@@@@@@@@@@@@@@@@@@@@@%%@@@@@%##@@@@
@@@@@@@@@@@%%@@@@@@@@@@#//@@@@@@@/**//%@@@@@@@&&&@@@@@@@@@#//@@@@@@@@@@%%@@@@@@@
@@@@@@@@@@@@@&%%%% &@@@@&& &/////%%&@@@@%%%%%%%%@@@@@&&&&&%%%%%%%@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@..///&&/**/////////////////#%%//%&&..,**&&&&&&&&%%@@@@@%%###@@@@
@@@@@@@@@@@@@@@@@@@@@//,....///%%(////#%%*****%%%%%@@(**@@(//##%&&%%@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@**...//#%%&&%%%%%&&&/////%%%%%&&&@@%%%##//%&&%%@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@..///%%&&&&&&&&&&&&&&&%%%//#%%&&&@@%%%%%//%&&%%@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@..///&&(//%%(////#%%//%&&//#%%&&&@@&&(//##%&&%%@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@//#%%&&*..............#&&%%%%%&&&@@((###&&&%%&&&&&&&&&&@@@@
@@@@@@@@@@@@@@@@@@@@@//%&&//%&&..........&&(//&&%%%&&&@@&&&&&%%#####%%%##%&&@@@@
@@@@@@@@@@@@@@@@@@@@@%%&& &//%&&.....     &&(//&&%%%@@&%%%%%%%##(////(##//%&&@@@@
@@@@@@@@@@@@@@@@@@@@@@@&& &##,..............(##&&&@@@@@@@@@@&&%%###//(##//%&&@@@@
@@@@@@@@@@@@@@@@%%@@@&&%%%%%%##//////////##%%%%%&&&@@&%%@@@@@@@&%%//(##//%&&@@@@
@@@@@@@@@@@@@@@@##@@@//&@@&&###//(##/////&&@@@@@#//@@%##@@@@@@@@&&#####//%&&@@@@
@@@@@@@@@@@@@&%% ((#%%@@@@@&&*,,##*,,##%%%//&@@@@@@@##(((%%@@@@@@&&#####//%&&@@@@
@@@@@@@@&%%##(((#######&&&%%&@@,,(##%%(//@@&%%&&%#######((###%%&&&#####//%&&@@@@
@@@@@@@@@@@@@%##((&@@&&,  ##&&&&&&&&&&@@@@@@@@,,#&&@@#((##&@@@@@&&###%%//%&&@@@@
@@@@@@@@@@@@@&%%@@@@@##*,,&&*,,//#%%&&&@@%%@@@//&@@@@@@@%%@@@@@@&&###%%##%&&@@@@
@@@@@@@@@@@@@@@@@@@@@&&&& &@@%#######%%&&&&&@@@@@@@@@@@@@@@@@@@@@&&#####&&@@@@@@@
@@@@@@@@@@@@@@@@@@@&&,, &@@&& (////#%%%%%%%@@@@@@@/,,@@@@@@@@@@@@@&&#####&&@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@%%%//#%%%%&@@@@@@@@@@@@&&@@@@@@@@@@@&&#####&&@@@@@@@
@@@@@@@@@@@@@@@@&&@@@@@&%%&&@@@&&&&&&&&&&@@@@@@@@@@@@@@@@@@@@@@@&&##%&&@@@@@@@@@
@@@@@@@@@@@@@@&&@@@@@@@@&&  .,,//#####(////(##@@@@@@@@@@@@@@@@@@&&##%&&@@@@@@@@@
@@@@@@@@@@@&&@@@@@@@@@@@&&##&&&&&@@@@@@&&//%&&@@@@@@@@@@@@@@@@@@&&##&@@@@@@@@@@@
@@@@@@@@@&&@@@@@@@@@@@@@&& *//@@@@@@@@@@  *//@@@@@@@@@@@@@@@@@&%%&&@@@@@@@@@@@@
@@@&%%@@@@@@@@@@@@@@@@@&& &%%&& &@@@@@@@&& &%%&& &@@@@@@@@@@@@@@@@@&%%@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@&&,,#%%@@@@@@@@@@,,(%%@@@@@@@@@@@@@@@##&@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@&&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            ReadKey();
            ForegroundColor = ConsoleColor.DarkCyan;
            WriteLine("This guy looks different from what I saw, I do know he has the same scythe thing, hmmm...");
            ReadKey();
            WriteLine("Could this be... Skieth's true form? Looks like it's someone tough to get through to save that girl...");
            ReadKey();
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine($"{characterName}... You're almost there. It's only a matter of time for you\nto save me from Skeith.");
            ReadKey();
            ForegroundColor = ConsoleColor.DarkCyan;
            WriteLine("That girl's voice!");
            ReadKey();
            WriteLine("Wait, this key...! It's glowing!");
            ReadKey();
            ForegroundColor = ConsoleColor.Gray;
            WriteLine($"The crypto key floats away from {characterName}'s hands and floats in front of them!");
            //Add this to the item inventory once i get the item class even implemented.
            ReadKey();
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("They Crypto-key has changed form!\nYou now have access to the Encrypted Lake.");
            ReadKey();
            ForegroundColor = ConsoleColor.DarkCyan;
            WriteLine("Well, guess I should get outta here.");
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("Please press [Enter] to continue to Chapter 2.");
            ReadKey();
            while (ReadKey().Key != ConsoleKey.Enter)
            {
            }
            ForegroundColor = ConsoleColor.Gray;
            Chapter2(characterName, catName);
            return;
        }
        public void Chapter2(string characterName, string catName)
        {
            Clear();
            WriteLine(@"   _____ _                 _              ___  
  / ____| |               | |            |__ \ 
 | |    | |__   __ _ _ __ | |_ ___ _ __     ) |
 | |    | '_ \ / _` | '_ \| __/ _ \ '__|   / / 
 | |____| | | | (_| | |_) | ||  __/ |     / /_ 
  \_____|_| |_|\__,_| .__/ \__\___|_|    |____|
                    | |                        
                    |_|                        ");
            ReadKey();
            Clear();
            //Player heads back to town, gets some clues, heads to the encrypted lake, gets the antivirus shield. Add some scenarios here and there.
            WriteLine($"{characterName} walks back from the Abyss of Zeroes temple and sees {catName} again.\nIt seems he wants to talk to them.");
            ForegroundColor = ConsoleColor.DarkCyan;
            WriteLine("Man, what does he want now...?");
            ReadKey();
            Clear();
            ForegroundColor = ConsoleColor.Gray;
            WriteLine(@"                           .'\                
                          //  ;               
                         /'   |               
        .----..._    _../ |   \               
         \'---._ `.-'      `  .'              
          `.    '              `.             
            :            _,.    '.            
            |     ,_    (() '    |            
            ;   .'(().  '      _/__..-        
            \ _ '       __  _.-'--._          
            ,'.'...____'::-'  \     `'        
           / |   /         .---.              
     .-.  '  '  / ,---.   (     )             
    / /       ,' (     )---`-`-`-.._          
   : '       /  '-`-`-`..........--'\         
   ' :      /  /                     '.       
   :  \    |  .'         o             \      
    \  '  .' /          o       .       '     
     \  `.|  :      ,    : _o--'.\      |     
      `. /  '       ))    (   )  \>     |     
        ;   |      ((      \ /    \___  |     
        ;   |      _))      `'.-'. ,-'` '     
        |    `.   ((`            |/    /      
        \     ).  .))            '    .       
     ----`-'-'  `''.::.________:::mx'' ---    ");
            ReadKey();
            ForegroundColor = ConsoleColor.Green;
            WriteLine($"{characterName}! {characterName}! I have vewwy bad news to teww yew!!!!!!!!!");
            ReadKey();
            WriteLine("The town is gone! It's just compwetewy gone!!! Everyone turned intew fishes!!!!!!!");
            ReadKey();
            ForegroundColor = ConsoleColor.DarkCyan;
            WriteLine("Damn! I bet this was Skeith's doing!\nI need to get over there quick and see what's going on!");
            ReadKey();
            ForegroundColor = ConsoleColor.Gray;
            WriteLine($"{characterName} picks up {catName} and runs towards the clone of their hometown.");
            ReadKey();
            ForegroundColor = ConsoleColor.DarkCyan;
            WriteLine("HOLY... What the absolute freck happened here?");
            ReadKey();
            ForegroundColor = ConsoleColor.Gray;
            WriteLine("All the town buildings are gone, and there's nothing but fish bowls\nand mobs of various fish flopping on the ground.");
            ReadKey();
            ForegroundColor = ConsoleColor.DarkCyan;
            WriteLine("Yup, this IS something an evil entity would do!");
            ReadKey();
            ForegroundColor = ConsoleColor.Gray;
            WriteLine("You feel the Crypto-key pulsating in your pocket. It seems it's trying to tell you something.\nYou don't hear anything from it, but it's telling you to head to the Encrypted Lake.");
            ReadKey();
            WriteLine($"{characterName} and {catName} then proceed to head to the Encrypted lake.");
            ReadKey();
            WriteLine($"After running for a while, {characterName} and {catName} finally made it.");
            ReadKey();
            WriteLine("You see someone with long, Gray hair, and wearing a helmet, staring far off into the lake.\nHe turns around and looks at you.");
            ReadKey();
            Clear();
            ForegroundColor = ConsoleColor.Gray;
            WriteLine(@"                                               #                                
                                               &                                
                                  *            #                                
                                 ./           /(                                
                                 /*           (%                                
                                ,.           (.*                                
                                //           &,*                                
                               * *           #*(                                
                               /,            %,%                                
                              ..(            &.(                                
                              /,#            (,*,                               
                              (,#            ./,&                               
                              (*(             (,%                               
                              (*..       /*   #,#                               
                              ,.*#      %&#(* %.(.                              
                               #//     */%#(/##,#                               
                               %//%    &## ###*(&                               
                               #*(&   &/&#  #/./%,.                             
                               &*(&*%&&&&&%//./%*,/*,(                          
                              (/**/#%%&*#%#,,/#,****,*,*/  ,.                   
                            #####&%%##%%/#./*&& /.**,*,,,* . .                  
                           #&&%&&&(@(%*%&*#((%&&  *.(,..*.,/*                   
                          .@@####&&%%#%%&&&&&%%%/*&,/./ /(***(*.                
                        ,*(((#*(##*,(%#&%&%%&%%&%(%%%#(//#(*,**&                
                     .*((/*##&(**/(/#(&&#@%%&&%#((/##%(#%(./@                   
                        .     *..  ,##%&&&(%#(%%%(((,,/((/(                     
                      /. **/((#%...,,**((&/&#(&//#/*(&%/@                       
                     ,* (.(**#(/#,,,,&&%%/%&/(##&@@&&&(&@                       
                     /&&*#%&%#(%%%##/***%&/#%##*,***////*/.(                    
                  &//(%*%%&@@&%%&&&((&@@%#@##(/&@#/*,*/(#%#&#                   
               .&#%%%&%./##(*,,*,.#((((%##%&&&&%%###((##%&&%&/(                 
             /@%//((/&#(#/**//((//*/&##%@((#//%&&&&%%%%&&&&%%#/&                
            @(#%%#(&@%%&((((/*%%%%%##*@(@(#%@@@#/,*/##(/(##*%//(@(              
          &%&&&&&&@@@%**#@%&&%%##(**,((((%&%&@@@&@((%&%%&&@&%&#@                
          @%###%&&&@@@@@#%((#&&#&&&@&%%%%%&@@@&@@&&&&%##%&&&%##(@      .        
   (#,%/@&%#%&&&&@@@@@@&*%%/#%&%##(#%##/@@@@@@#@@&&&&&&&&%(**#@&       ,.       
%%%%&@%/&&&&&&&&%(@,  &#/*//(#%&@&%%(#@@@@@@@@&@@@&@@&&%&&&&&&%(       %.  .    
##%&&&%&&(&&%&(&       @&&&&&&&&%%&#(&&&&&&&&&&#@@@@@@&&&%%&%@##.     #%  ,.    
&&&&&&/%(#%#%%&%#((&,  .@@&&&%&#(#&@&&&%%%%%&@@&&&@&@@&&&&&#%%&%.  *&%#  %/     
%&%%%#&@.  (&#(##%#    *(@@@@@@&%%(##%%####&@@&&&&&&@&@&%&&&#%&&*&&%%,#%(,      
                       *&&@&&&&%&&&%%&&@@@@@@@&%&%&%&&@ ,@&&&&%&(&%&#%#,        
                    #@@%&%#@#@&%%@&&(/##%%@@@&&%&%%%%&@ (#((#%%%%#(#@@@,%#      
                  #(&&#@&@(%%##%&&#%%(%%#/&&@%%%%%%%%&@ %&&&%&&%&&%(%&&&/      ");
            ForegroundColor = ConsoleColor.Blue;
            WriteLine("... ... ... ...");
            WriteLine("I sense something very powerful within you. Something as great as the light.");
            ReadKey();
            WriteLine("You seems like you've come from another world, another dimension. Please, lend me your strength.");
            ReadKey();
            ForegroundColor = ConsoleColor.DarkCyan;
            WriteLine("W-Wha!?? Do you have the same objective as me?");
            ReadKey();
            ForegroundColor = ConsoleColor.Blue;
            WriteLine("Perhaps I do. Fighting the darkness, right?");
            ReadKey();
            ForegroundColor = ConsoleColor.DarkCyan;
            WriteLine("Yeah, but it's Skeith.");
            ReadKey();
            ForegroundColor = ConsoleColor.Blue;
            WriteLine("... ... ...\nThen we do have the same objective of overcoming darkness...");
            ReadKey();
            ForegroundColor = ConsoleColor.DarkCyan;
            WriteLine("(Uhhhh whaaaaaaat??? Is this guy okay?\nThis world is filled with strange people.)");
            ReadKey();
            ForegroundColor = ConsoleColor.Blue;
            WriteLine("Who ARE you? And why did you come here?");
            ReadKey();
            ForegroundColor = ConsoleColor.Gray;
            WriteLine($"{characterName} told the man everything that has happened so far.");
            ReadKey();
            ForegroundColor = ConsoleColor.Blue;
            WriteLine($"I see... Well, in that case, please, take me with you, so we can defeat\nSkeith together, {characterName}.");
            ReadKey();
            WriteLine("We are going on a trecherous journey. Please, take this.");
            ReadKey();
            ForegroundColor = ConsoleColor.Gray;
            WriteLine($"{characterName} got the Antivirus Shield!");
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("You now have access to the Corrupted Caverns.");
            ReadKey();
            ForegroundColor = ConsoleColor.DarkCyan;
            WriteLine("What's your name, by the way?");
            ReadKey();
            ForegroundColor = ConsoleColor.Blue;
            WriteLine("My name... I don't recall having one, but you can give me a new alias.");
            ReadKey();
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("What would you call this person? Please type in a name:"); //okay I wanna add more user-inputs for once so here it is lol
            string knightName = ReadLine();
            ForegroundColor = ConsoleColor.Gray;
            WriteLine($"You decided to name him {knightName}.");
            ReadLine();
            ForegroundColor = ConsoleColor.Blue;
            WriteLine($"That's right! My name is {knightName}!\nAllright, {characterName}, let's go!");
            ForegroundColor = ConsoleColor.Gray;
            WriteLine($"{characterName} and {knightName} head to the Corrupted Caverns.");
            ForegroundColor = ConsoleColor.DarkCyan;
            WriteLine("It's so dark in here!");
            ReadKey();
            ForegroundColor = ConsoleColor.Blue;
            WriteLine("Don't worry, I'll make some light");
            ForegroundColor = ConsoleColor.Gray;
            WriteLine($"{knightName} casted a spell of light that lit up the entire cave!");
            ReadKey();
            WriteLine($"{characterName}, {knightName}, and {catName} traversed through the giant caves carefully,\ncautiously watching out for the static-spewing geyzers.");
            ForegroundColor = ConsoleColor.Green;
            WriteLine($"Owh my gawd it's hot here uwu! {knightName}, how are yew not hot?");
            ForegroundColor = ConsoleColor.Blue;
            WriteLine($"I've been stuck in this world for too long. I, too, need to get out of here, like {characterName}.");
            ReadKey();
            ForegroundColor = ConsoleColor.Gray;
            WriteLine($"{characterName} sees a sturdy sword on their right!");
            ForegroundColor = ConsoleColor.Yellow;
        SwordPickup:
            WriteLine("What should they do?\n1) Pick it up\n2) Leave it alone");
            ConsoleKeyInfo info = ReadKey(true);
            if (info.Key == ConsoleKey.D1)
            {
                WriteLine($"{characterName} picked up the sword. You can feel it's holy power enter your soul.\nYou have the courage to do anything!");
                goto AfterItemGet2;
            }
            if (info.Key == ConsoleKey.D2)
            {
                WriteLine($"{characterName} did not pick up the sword. It looks too heavy to carry, anyway.");
                goto AfterItemGet2;
            }
            while (info.Key != ConsoleKey.D1 && info.Key != ConsoleKey.D2)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"You cannot escape, {characterName}. Please make a valid selection.");
                ForegroundColor = ConsoleColor.Gray;
                goto SwordPickup;
            }
        AfterItemGet2: //okay basically the user input above does nothing but it DOES give it some kind of flavor and less bland at least...
            ForegroundColor = ConsoleColor.Blue;
            WriteLine("We're almost there. Just a few more miles...");
            ForegroundColor = ConsoleColor.Gray;
            WriteLine($"{characterName} and the crew walked behind a giant waterfall of lava-- or rather, a lavafall?");
            ReadKey();
            WriteLine("And they finally made it out! But they've encountered a blockade!");
            ReadKey();
            ForegroundColor = ConsoleColor.DarkCyan;
            WriteLine("This seems to be a firewall. Is this a dead-end?");
            ForegroundColor = ConsoleColor.Blue;
            WriteLine("Let me see that map you have, I think there's a detour.");
            ReadKey();
            ForegroundColor = ConsoleColor.Gray;
            WriteLine($"{characterName} showed the map.");
            ReadKey();
            WriteLine(@"
____________________________________________________________________
|                                                                   |
|                                                      - The Kernel |
|                                                     /       |     |
|                                                    /        ?     |
|                         Corrupted Caverns- - - - -/         ?     |
|                        /               \                    ?     |
|                       /                 \                   |     |
|                      /                   \- - - - - Net Slum      |
|                     /                                             |
|     Town - - - - - -                                              |
|        \ - - - -- - - - - - - - - Encrypted Lake                  |
|         |                                                         |
|         |                                                         |
|         |                                                         |
|         |                                                         |
|         |                                                         |
|        Scenic Park - - - - - - - - - Abyss of Zeroes              |
|                                                                   |
|                                                                   |
|___________________________________________________________________|");
            ReadKey();
            ForegroundColor = ConsoleColor.Blue;
            WriteLine("Oh, oh dear...");
            ForegroundColor = ConsoleColor.DarkCyan;
            WriteLine("What?");
            ForegroundColor = ConsoleColor.Blue;
            WriteLine("We'll have to go through... The Net Slum.\nThat's where everything that's considered an abomination on the Internet is thrown into. A cesspool of toxic waste.\nWe must be very careful when passing by these lands.");
            ReadKey();
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("Please press [Enter] to continue to Chapter 3.");
            ReadKey();
            while (ReadKey().Key != ConsoleKey.Enter)
            {
            }
            ForegroundColor = ConsoleColor.Gray;
            Chapter3(characterName, knightName, catName);
            return;
        }

        public void Chapter3(string characterName, string knightName, string catName)
        {
            Clear();
            WriteLine(@"   _____ _                 _              ____                                             
  / ____| |               | |            |___ \                                            
 | |    | |__   __ _ _ __ | |_ ___ _ __    __) |                                           
 | |    | '_ \ / _` | '_ \| __/ _ \ '__|  |__ <                                            
 | |____| | | | (_| | |_) | ||  __/ |     ___) |                                           
  \_____|_| |_|\__,_| .__/ \__\___|_|    |____/                                            
  /\/|______ _      | |    _____                     _   ______ _             _      _ /\/|
 |/\/__   __| |     |_|   / ____|                   | | |  ____(_)           | |    | |/\/ 
       | |  | |__   ___  | |  __ _ __ __ _ _ __   __| | | |__   _ _ __   __ _| | ___| |    
       | |  | '_ \ / _ \ | | |_ | '__/ _` | '_ \ / _` | |  __| | | '_ \ / _` | |/ _ \ |    
       | |  | | | |  __/ | |__| | | | (_| | | | | (_| | | |    | | | | | (_| | |  __/_|    
       |_|  |_| |_|\___|  \_____|_|  \__,_|_| |_|\__,_| |_|    |_|_| |_|\__,_|_|\___(_)    
                                                                                           
                                                                                           ");
            ReadKey();
            Clear();
            WriteLine($"Previously on CYBERSPACE...\n{characterName} met a strange guy at the Encrypted Lake, named {knightName}.\nThe two, plus {catName} from earlier in the story, need to head to the Kernel since now they are prepared.\nAfter tekking through the Corrupted Caverns, they've encountered a blockade at the exit, making a detour\nto the infamous Net Slum. There is uncertainty awaiting... Can the girl, Aura, be saved from Skeith?");
            ReadKey();
            Clear();
            WriteLine($"{characterName}'s team arrived at the Net Slum. It looks like an extremely busted neighborhood with\nboarded up windows on every house.\nIt looks like everything's been tainted");
            ReadKey();
            WriteLine($"A humanoid body with the face of an emoticon approached {characterName}.");
            WriteLine(@"                                                                                
                           @@@                         @@                       
       @@       @@   @@      @@    (@      @@         @          &@             
      @@        @    @             (@      @@                     @@            
      @@       .@   /@             @@      @@                      @/           
      @@     @@@@@@@@@@@           @.      @@                      @.           
       @       @    @            @@@@@@@@@@@@@                    @@            
       ,@                        @%         @@                   @@             
                                                                      ");
            ForegroundColor = ConsoleColor.Magenta;
            WriteLine("Use Cedar.");
            ReadKey();
            WriteLine("Use Cedar.");
            ReadKey();
            WriteLine("Use Cedar.");
            ReadKey();
            ForegroundColor = ConsoleColor.DarkCyan;
            WriteLine("Back off! Geez!");
            ReadKey();
            ForegroundColor = ConsoleColor.Gray;
            WriteLine("The smell of burnt silicon fills the air. It feels as if your lungs are burning inside.");
            ReadKey();
            ForegroundColor = ConsoleColor.DarkCyan;
            WriteLine("COUGH COUGH! *gasps*");
            ReadKey();
            ForegroundColor = ConsoleColor.Gray;
            WriteLine($"The emoticon person continues to follow {characterName}.");
            ReadKey();
            WriteLine(@"                                                                                
                           @@@                         @@                       
       @@       @@   @@      @@    (@      @@         @          &@             
      @@        @    @             (@      @@                     @@            
      @@       .@   /@             @@      @@                      @/           
      @@     @@@@@@@@@@@           @.      @@                      @.           
       @       @    @            @@@@@@@@@@@@@                    @@            
       ,@                        @%         @@                   @@             
                                                                      ");
            ForegroundColor = ConsoleColor.Magenta;
            WriteLine("Use Cedar.");
            ReadKey();
            WriteLine("Use Cedar.");
            ReadKey();
            WriteLine("Use Cedar.");
            ReadKey();
            ForegroundColor = ConsoleColor.DarkCyan;
            WriteLine("AAAARGHHHH!!!!");
            ForegroundColor = ConsoleColor.Gray;
            WriteLine($"{characterName} turned around in irritation and knocked the person out with one hard slap!\nThe face ripped like it was a piece of paper.");
            ReadKey();
            WriteLine($"Another person, but with a different face, walked up to {characterName}.");
            ReadKey();
            WriteLine(@"                                                                                
       @@    @@      @                                       @    @             
      @@    @&       @                                        @&   *@           
     @@    @@        @     @@@                          @@@    @    @           
     @@    @@        @     @@@@@                      @@@@@    @    @.          
      @    @@        @                                         @    @           
      @@    @@       @              @@  @@  @@ @@*            @    @    
");
            //The incorrect formatting in this string is intentional
            ForegroundColor = ConsoleColor.DarkGreen;
            WriteLine("High Efficiency Video Coding (HEVC), also known as H.265 and MPEG-H Part 2, is a video compression standard designed as part of the MPEG-H project as a successor to the widely used Advanced Video Coding (AVC, H.264, or MPEG-4 Part 10). In comparison to AVC, HEVC offers from 25% to 50% better data compression at the same level of video quality, or substa");
            ReadKey();
            ForegroundColor = ConsoleColor.DarkCyan;
            WriteLine("Oh not this again!");
            ReadKey();
            ForegroundColor = ConsoleColor.Gray;
            WriteLine($"{characterName} bolted as fas as they could, leaving the Net Slum.");
            ReadKey();
            WriteLine($"After running through wastelands, {characterName}'s team finally made it to an underground passage.");
            ReadKey();
            ForegroundColor = ConsoleColor.DarkCyan;
            WriteLine("I think this is the Kernel. Let's go.");
            ReadKey();
            ForegroundColor = ConsoleColor.Gray;
            WriteLine($"As {characterName} wanders around the kernel, they realize that it looks vastly similar to the temple\nthey went to in the Abyss of Zeroes.");
            ReadKey();
            ForegroundColor = ConsoleColor.Green;
            WriteLine("Is this the kewnel uwu?");
            ReadKey();
            ForegroundColor = ConsoleColor.Blue;
            WriteLine("Yeah. Basically, it may look like a billion years old, but this is the foundation of the entire world we're in.\nIt's huge and ancient. well, 'ancient' being made in the 1990's, but still holds up today.\nNo one's really supposed to be here--");
            ReadKey();
            ForegroundColor = ConsoleColor.Gray;
            WriteLine("The ground starts to rumble. It's a sign something is coming.");
            ReadKey();
            WriteLine("The monster, Skeith, appears in front of the team!");
            ReadKey();
            Clear();
            WriteLine(@"        *######%# ,,,,,,,,,*       .  /                                         
          ./%%%%%* /,,,,,*        *,,*,,. *                                     
          .*.   (%. .            .*,,,,,,/,,./                                  
(            .  #%&* *            ,*.,**,,,,/,*./                               
 *     ..,,/. %&%%&&& *               ,/,*/,,,*/,.,.                            
 /   ,,,,.*.,&&&&&&&@@# /                 #,,/,,,/, *         /*       .((      
 .  .,,,.,*./ %&&&&@@@@@#,/.                ,*,*,,** .      *  ,.,,      ,..#   
    .,....*./* ,&&&@@@@@@@@,*(.               ./,**,,*/      ,. ,*..       . ,. 
    ......,..,(/ #&&&@@@@@@@@&**/(              /,,(. %      //,/(.,.,,,,,*./   
.....,,,,,,,/*..../&@@@@@@@@@@&&@(...,,.        ,(/#@%%.     #(,(.,.,,,,,/..    
../%&&&&&&&@@@%./../.&@@@@@@&&&&@@, .,     (*,,*#@@@@&&   .%(. /,,,,,,,,,,#     
%%%&@&&&&&@@@@@@@&/.(*,*@@@&&&&@,     *     ,#@&@@@@@&&   **,,,,,,,,***,,(*.    
&&&&&@%*.  .,%@@@@@(,. /,,*%@@&   ,,,**(//*** #&&@@@@&.,,***,*#&%%%%%%%%(,***(((
&@&#(######&(   %@@@,,    (,.,*.*,//*//(//**(/(@@@@%./,****@&%%@@&&&&@@@&&&(****
&&&&&&&&&&&&@%&, /@@%.       .*.,./(///(/**%#%(#.*/******&@@@@&&&&%#%&&&&&&%&/**
&&&&&&&@@@@&@@&%# %@@ .*.     .,*,,#//#%*,,%%(#* ..,****@@@&&&%%#(,,****&&&&%%/*
@@@@@@@&&&&@@@@&%%/@*  */,     *,*,(//%%...,/#% . ,**,,@@&&&@@@&&&@@%(,*,%&&&&#*
&&@@@&&@#####(@@@&/@ .***#%(/*.**///#****,,*#(  . ,,*,@@&&&&&&&&&&@@@&%/*,@&&@&*
&&&@@@&&#(((((#@@&*.(**@@@@@@/*//(**&@%/**&&/    ..,,,&&&&@&&&&&@@@@@@&%/,(&&@@*
&&&&@@@@%((//(@&&( .**(@@%%%%&@%*..,#@@@@@#/  ,, , ,,,&&&@@&&@@@@&%###%@@*%&&@@,
&&&@@@@@@@@@@@@@/..*/@@@%    /@@@@@(***(/*/*(%#** ...,&&&@@@@@@&@(((((#(&,&&&@&,
#%%%&&@@@@%%##(   /(/@@,      *@@@@@@/./,.&@@@@%*  ...*%&@@@@@@@&##(**/%,@&&@@(.
.*((&@&####/       ,/..    #@@@@@@@@@@@@@@@@@@@(*   . ./&&@@@@@@@@@@&%(/@&&@@&,,
&&@#,    ,(&&*            ,@@&%. ,%@@@@@@@@%%%@&,    , ..,%%##((##%//*@&&&&@**,%
@@@@@@@@@@@@(             /&#    .&@@@@@@@@@*%&              .,.(%@@@&&&&&****# 
***/###(,./                      *@@@@@@@/%%%            , .,*&&%%&&&@@&****#, .
     /*                           &&&@@@,   *             ,,*///*//###****%.  * 
,                                 ##%@%                     ./.,/////**,#   *   
                                #(&@@%#&%                           ,#. ,*      
                                (#@@@%&&@              .,/(#%&%&/   ,,          
                                 /%&&@@(       *#(,..........  ,*           ., ,");
            ForegroundColor = ConsoleColor.Red;
            WriteLine("GRRAAAAAAAAAAAAARRGHAAAGHAAAAAAAAAAA!!!!!!!!!!!!!!!!!!!");
            ReadKey();
            ForegroundColor = ConsoleColor.Gray;
            WriteLine("The intimidating, freightening appearance of Skeith, in fact, gives you the courage to face death.");
            ReadKey();
            WriteLine($"{characterName} doesn't feel scared in the slightest! Although, {catName} and {knightName} fled, {characterName} still\ndoesn't feel they're alone.");
            ForegroundColor = ConsoleColor.DarkCyan;
            WriteLine("Now THIS means business! Let's take this thing down!");
            ReadKey();
            ForegroundColor = ConsoleColor.Gray;
            WriteLine($"The Crypto-Key was still in {characterName}'s pocket this entire time. It flies out of their pocket and\nshines a bright light!");
            ReadKey();
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine($"{characterName}!! The descendant of the light!!\nCast the prophecy and manifest the resolution before your very eyes!");
            ReadKey();
            ForegroundColor = ConsoleColor.Gray;
            WriteLine($"Skeith waits for {characterName} to make their first move. This moment is cruical.");
            ReadKey();
        GrandFinale:
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("What will be your final call?");
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("1)Purge the impurity and eradicate all sin!\n2)Forge the bonds into a bright new future!");
            ConsoleKeyInfo info = ReadKey(true);
            if (info.Key == ConsoleKey.D1)
            {
                WriteLine($"Purge the impurity and eradicate all sin!");
                ReadKey();
                goto BadEnd;
            }
            if (info.Key == ConsoleKey.D2) //THE correct choice
            {
                WriteLine($"Forge the bonds into a bright new future!");
                ReadKey();
                goto GoodEnd;
            }
            while (info.Key != ConsoleKey.D1 && info.Key != ConsoleKey.D2)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"You cannot escape, {characterName}. Please make a valid selection.");
                ForegroundColor = ConsoleColor.Gray;
                goto GrandFinale;
            }
        GoodEnd:
            ForegroundColor = ConsoleColor.Gray;
            WriteLine(@"                                                                                
                  ..*&,.......,(,,**,*#@(*,,,*/#&(,,,,,,,*(%%&@@@@@@@@@@%#(//***
                 ...&*........((/,,#%#(/***&%&@&(@%@%@@@@@@@%#(@%(&&#(***,,,....
        .............,&/*/**/&#&*****(%#((&%@@@&##(/***********/%(/&&@%(*,..... 
       ......................,,*(##&%#(&@(/(((&%##%&@@&#(#@#//(&#@&#&@%(/,...   
      .........................,#&/(//**%****//(#(/(((%@@@&#@@@@@@(%%(##(,,...  
     ....................,,.,***(/(*(&/&#//(%///&@@@@%&&&(&##&&&((/((%@@%((*/*,,
    .................,,,*(&(/(&*&/***/*,/(%#&@@###&&&@%/(%%(//*///#(&&@(((@@@@@@
    ..........,,,,,,**/(@&&//&/***%@&/*,,,**%##@@%(%%#&&(%(%%((**//&(/**,,,,,,,*
......,/#,...,,#***/%@@&(((%@@&///*#%#%&,..,,*%%#@@@&&#((//*****(@&#///,,,.,....
  ....,.,*#/,*///(@@@(/*//(@@%((/#/*,*&*&,....,,*(%%@@@%@&@&(*@%/(%&&@(/*,..... 
   ..,,%(%///((&@@(/**,**(@@&@&%#/*,***(*/#,....,,,*&%&&#%@%/*,,,,,,**/%@&,.....
.....,//#//*%#@&/%//#(/(*,,,,,/******%%&#*,,... ...,,*/@&@@#/*,,....,,,,,,......
,.,..,,*/(/*/***,,,.,,,.....,,(&(&%(/(@%/*,*.. .. ....,,*%(%@@/,,,..............
..,,,*((@@/*/*,,.,,.*,,,,#%(#,,,,(*//(@@(#&,.... .  .....,,##/**,,*,,,,,,,,,***/
.,,*#@&%**,,,*/*,/*(/#&**........,,%%///%&&&*,...  .  ......,(%(***/(//(((##%%&@
,/@@&***,........,,(@/,.........,,**(////&%%/**,...  ..  ....,,/@&&&&@@@@@@@&%%#
&%*,,,.......,...,@&(,,........,,**/(#&@#((&&%*,,....  ..  ....,,(%@&&&%%#(((//*
");
            ReadKey();
            ForegroundColor = ConsoleColor.DarkGray;
            WriteLine("Take THIS!! Beam of Light!!!");
            ReadKey();
            ForegroundColor = ConsoleColor.Gray;
            WriteLine("BOOOOOOOOOOOOM!!!");
            ReadKey();
            Clear();
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("You have made the right choice");
            ReadKey();
            WriteLine("You have done Everything to save me.");
            ReadKey();
            WriteLine("You have liberated me from this endless cycle of history.");
            WriteLine($"{characterName}...");
            ForegroundColor = ConsoleColor.Gray;
            WriteLine($"{characterName} places their hands out, and the girl gently floats on their arms. She seems to be waking up.");
            ReadKey();
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine($"{characterName}... Thank you... Thank you for saving me.");
            ForegroundColor = ConsoleColor.Gray;
            WriteLine($"A white flash of light happened right before {characterName}, and ascended up into the holy light.\nThey've finally returned home, safe and sound, unharmed.\n{characterName} wakes up on their bed, in their room, ready to start another day in the real world.");
            ReadKey();
            Clear();
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("T H E  E N D !");
            ForegroundColor = ConsoleColor.Gray;
            WriteLine("CHARACTER CAST:");
            ForegroundColor = ConsoleColor.Gray;
            WriteLine($"~~~ Main Characters ~~~");
            ForegroundColor = ConsoleColor.DarkCyan;
            WriteLine($"{characterName}");
            ForegroundColor = ConsoleColor.Blue;
            WriteLine($"{knightName}");
            ForegroundColor = ConsoleColor.Green;
            WriteLine($"{catName}");
            ForegroundColor = ConsoleColor.Gray;
            WriteLine("~~~ NPCs ~~~");
            WriteLine("Stranger from chapter 1");
            ForegroundColor = ConsoleColor.Magenta;
            WriteLine("Net Slum Villagers");
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("Aura");
            ForegroundColor = ConsoleColor.Red;
            WriteLine("Skeith");
            ForegroundColor = ConsoleColor.Gray;
            WriteLine("\n\n\nPress [Enter] to quit the game. Hope to see you again in the next journey!");
            while (ReadKey().Key != ConsoleKey.Enter)
            {
            }
            Environment.Exit(0);

        BadEnd:
            ForegroundColor = ConsoleColor.Gray;
            WriteLine("You hear Skeith's raspy smoker voice.");
            ReadKey();
            ForegroundColor = ConsoleColor.Red;
            WriteLine($"Oh, {characterName}.\nHow foolish foolish of you, {characterName}.");
            ReadKey();
            WriteLine($"Impurities and Sin are inevitable, {characterName}.");
            ForegroundColor = ConsoleColor.Gray;
            WriteLine("Skeith has consumed you in darkness, never able to come back...");
            ReadKey();
            WriteLine("All for naught. What a shame this had to be!");
            ReadKey();
            Environment.Exit(0);
        }
    }
}

//System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=Egn_VNVKzI4");
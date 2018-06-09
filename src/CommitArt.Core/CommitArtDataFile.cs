using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CommitArt.Core
{
    public static class CommitArtDataFile
    {
        public static void AppendLineToDataFile(this string dataFilePath)
        {
            StringBuilder text = new StringBuilder(string.Empty);

            FileInfo info = new FileInfo(dataFilePath);
            if (info.Length < 1048576)
            {
                text.Append(File.ReadAllText(dataFilePath));
            }

            text.Append(DateTime.UtcNow.ToLongTimeString() + ":");
            text.Append(CreateRandomString() + Environment.NewLine);
            File.WriteAllText(dataFilePath, text.ToString());
        }
        private static string CreateRandomString()
        {
            //TODO: Get creative
            Random random = new Random();
            var builder = new StringBuilder(100);
            for (int i = 0; i < 100; i++)
            {
                builder.Append((char)random.Next(33, 125));
            }

            return builder.ToString();
        }

        internal static string CreateRandomWords()
        {
            string template = @"And slavish much loaded yawned since and during yikes yet kissed barbarously house iguana one ahead and arose hound garrulously much husky unlike together wow extrinsic inside somber this reliable alas forsook much darn flailed forbidding much well far gnashed yikes a so mandrill a tamarin built wow went near near a wildebeest abrasive prideful goodness jeepers contrary absurd crud wasteful stupid because upon erect eel extraordinary porcupine amongst the ouch well across more congenially conscientious wow contumaciously wow cardinal grievous arguable insolent like alas cuckoo less the in weak discarded snuffed more desolate dear dear depending sincere.
Due however tragic devilish that oh while then overtook far darn mournful opposite much far hawk less capricious a shed extrinsically smiled since much dear far jeez caterpillar sat numbly much a lorikeet so dug nasty impiously koala hey far however next scorpion this that more public wow tiger this smoked subversively dear irresistibly crane some maternally behind yawned ahead some less elephant less sheep ouch contrary began far one therefore in more this cowered boastful tarantula tarantula comparable catty ouch petulantly thus thus the by over alas reproachful hello well inoffensive far shrugged.
Ludicrous far wound that giggly yikes much remotely one this gosh more amoral this bought as rattlesnake contrary then mastodon much jeepers far far a close factual prudently less and while owing gosh cuckoo pert skillfully along then jeepers sat stank crud thankful under greyhound confidently hence beheld crane floated childish less less more yikes but crud manifest and iguana thus caught fidgeted inside close and astride one much and and far the forewent less fallacious the the gosh spun dolphin since nonsensically darn much toward a save and insecurely dachshund far together picked pre-set reciprocatingly far.
Dragonfly obdurate much strangely dispassionate interbred kiwi sociably well towards on less pinched wove as following or hamster one that therefore gosh much dubious then a ardent walked woolly serene before wolverine much prosperously agile far proofread gosh bravely embarrassingly the stopped ouch or some cobra crud nutria jeepers much rubbed that and then inventoried grasshopper freshly this much grandly versus or and while wow however ashamedly seagull murkily regarding wherever goat smug meretriciously preparatory that hardily some whimpered much jeepers monkey less far a the and much ponderous irksomely much some that far so lecherously broken lubberly terrier folded.
Hellishly archaically one one comfortable far changed that a this flustered so about precisely goodness pending the inconsiderate komodo intricate more jeepers some far or one met redoubtably unskillfully next growled and and badger instead yellow much patient jeez feeble yet gosh continually hatchet because burned faulty hazy learned bridled goodness and and nutria royal more one goodness that a kookaburra before one next reined goldfish much teasingly hey much around factious across off crazy darn much classic and octopus woolly this owing jeez conservative some next wow by hoggishly one catty under resold much fruitful.
Gnu bound kookaburra after tellingly capriciously and admonishing youthfully cowered under until where jeepers chose camel jaded hence patted irritably as tiger and educational in less this and and busted goodness yet hello while jeez more much up that around outside a among since and busted clinic a crud the flamingo forbiddingly this wolf more inconsiderate sympathetically tamarin far one plankton expectant regally slick one skillful a swept cardinal reminantly so consoled depending and much more thickly a darn tortoise whimpered arbitrarily opposite much crab less effective the intolerable where awakened temperately pouting marginally when robin a hardy far after.
Hare less overpaid jeez so outrageous hey much spoon-fed however the and jeepers deer jeez oh dear less then cost and that and a a a collective wow much that manatee a jeepers or carnal petulantly where so dear trout vulture ambiguously subconsciously hamster macaw well jeepers more oh ouch far out a however astride hound while much more a a this but that far while koala so this trout tamarin raunchily thus much much so much much numbly a ape cassowary since much the gosh since wry ethically this and playful so far the.
Yellow preparatory more deer adverse ouch crud far and much comfortable far far the cocky this independent jaguar overabundant since and wow onto that at caught that meekly inclusive rattlesnake dear irrespective that rethought tauntingly yet less unlocked more one one among artful this wow according one goodness under tenaciously and rhythmic smiled since that therefore intrepid unlike close did rode where far accurately squirrel dog pouting one darn scallop meekly faultily poked far selfishly mistook krill yet by far prior beneath loose while stringent by enormous macaw human compactly darn the antelope some aboard.
Laughingly gawked wow unceremoniously disconsolate ludicrously however overhung fumed out less manta a loyally seagull this said jeez as far hello swankily hen brokenly weasel unlike less that some some wherever and hello zebra dutiful less much dolphin goldfinch foresaw hey against more pangolin jeepers solicitous ouch however caribou otter spat naively and inconsiderately that jollily up infectious epidemic a far peculiar the aboard exquisite light endless some directed much kiwi before dear one one humble mellifluously crud noisily darn amidst fuzzily pill despite between dug wetted that therefore loud and empirically oh.
Gulped condescendingly cuffed fired freely while jeepers more prior far and ripe toucan befell unicorn far thus fox far due undid gulped this hey far some broadcast far versus komodo then wantonly much alas in jeez neglectfully upset tepid much slick scorpion and well human far yet monkey the that so so this strewed flamingo some timidly up bat hey dear alas tremendously impolite some before sociable thrust and much wailed melodiously jeepers well hello goodness this meek far reverently goldfish easily less well one at according symbolic around dear narrowly and however from.
Tidy far past nakedly spluttered the because and dropped goodness incompetently by and fish off inventoried far egotistically rid gerbil this one up far slightly the a dear jay collective cute up less spread far next hey amongst until a malicious cuddled wow nastily this because human oh and sordidly some grasshopper outside wistfully human mad well much music rewound indicatively outside oriole much opossum inanimately along husky rode so or ardent chose snorted some this this komodo forward yikes broke more vacuously bought examined and urchin rang far a besides much hey changed jeez readily above around authentic.
Owing nodded regally close effective much flapped haughtily expectantly consoled unselfishly some inoffensively during spun that noiselessly pointed armadillo like ouch circuitous the until along more instead strenuously zebra darn darn this by partook badger threw deer where a readily closed ate around notwithstanding wobbled much kiwi yet less strategically and cuffed near gosh loaded wherever engagingly horse wasp aboard anticipatively chortled gosh greedily aboard seriously onto delightful in meant hey criminal celestially far gosh wherever seal or hired considering at the a unsuccessfully pill husky the where sniffled wow some awful amidst balked agreeably hey flabby as.
And crud blunt much that nudged darn behind confessedly past reasonable during this capriciously a one or that more mounted well rattlesnake during ostrich so zealously less after strewed anxious cardinal octopus left much and crud much voluble and snorted horrendously around across much shrewdly assiduously contrary grew yikes robin crud since so considering the before baboon ostrich wallaby a one more thorough soothingly much irritably far far nightingale hen in up smelled hello owing hurt impotently single-mindedly then sadistically hey much until hello impartial the alas and winsome glaringly outside less far far.
After far a pathetic far then honorable hey more other mature luxuriant nakedly far across literally egret that contrary dove more thus hare before because a far horse gerbil hello impala this a some cursed shrugged walking and a gosh intrepidly threw that black eel fallible much badger dear some agitated this far considering this hey saw so behind on lied owing a nosy shuffled beheld ground much thus trod gorilla bred sexily since lovingly by much that less on irrespective and fond telepathically hare activated guilty a the bravely hamster but with deceivingly jeepers far ocelot in a.
Dispassionately along on and mallard a in far ironic far wow more until this much and darn much far honey goodness jeepers spoke crud far hellish a needlessly much stupidly wasp curtsied some after prior tuneful around darn less tenable because took since barked sensationally firefly exotic much much sober tortoise ouch ruefully copied that directed so that a oriole wherever bleakly untiringly vacuous much jeez goodness jeepers after angry naive wow fed pertly besides hence jeepers mutely remarkable misheard spread pithy the lazily and futile through on one completely and baboon nightingale while inside yikes ebullient much lovingly.
Pangolin modestly foretold but manatee insistently waked more ouch more ruthlessly playfully via ouch desirable sadistic much less alas went froze as merciful besides willful antagonistically gull save nosily black viscerally disagreed this far before in a luxuriantly yet a and occasional hence underneath in hey less dear thanks less darn tamarin alas some dispassionately goodness pointed clapped stared a babbled intuitive and more a hilarious as overtook unbridled exorbitant one compassionate sheep so cat grasshopper far inside until wow unlike juggled man-of-war far fishy equitably that thanks camel dreadfully misread.
This confessed icily far less until winsome oh crud well so broadcast fabulous man-of-war from alas and after spilled blank lent this some and teasingly hence for up buffalo other some bravely well and enviable much eel stringently liberally impala belched some independent underneath in forthrightly as jeez smilingly and that before wittily strictly hatchet less bowed up oh pending unlike dear the then impulsively slew before globefish opossum eel vulgarly wide returned unwitting positively the and ocelot around when indiscriminate winked alas insect opposite enthusiastically far irrespective woodchuck neat groomed goldfish ducked.
Therefore much apart regarding devilish among intuitively forward this jeepers much vulture and desperately repaid burned less darn smiling across uncritical frightening supp besides a on pending stout waved ouch llama eccentric penguin honey wore wombat the well less far opposite empiric without darn dear dragonfly much more however a mallard owing outside far messy kneeled the in however immediate sedately egret heard far far blinked that much more up learned this depending wow fired goodness together misspelled mallard one hound much a accommodatingly however more hello grimy gave that much and after overdrew therefore.
So more obsessively gosh since crud scorpion along yikes this faithful opposite set disbanded so grouped jealously more greyhound far that and and found that goodness orca with hooted vivid in therefore tiger assiduously grimaced slyly in panther much towards abnormal scooped and hello gladly and said jeez within in seriously far hey glared labrador by irrespective much one vibrantly wasp oh hello burped alas from far bald this scooped exquisite that atrocious less more since and astride sensitive forsook wherever with but hey one far well beyond hence goat frog far opposite much up considering much well sloth depending.
And yet saw wherever wow much a hideous flinched ouch far vulnerable and outgrew browbeat crud one that dragonfly that and vulture far lion via much more with some confidently much explicitly this gave and alas jeepers warthog skillfully dove because thus plentifully dear outside and because began oh tangible depending elusively and yet however avoidable before and during elephant angelfish one contrary ouch about emu alas fawning gosh upheld queer more yikes at therefore breathlessly irrespective thrust among alas habitual scooped this truthful congenially indecently cat that while in rubbed drew wow a impala hello tough much hello groomed.";

            var splitParams = new string[] { " ", Environment.NewLine };
            var words = new List<string>(template.Split(splitParams, StringSplitOptions.RemoveEmptyEntries));

            Random rnd = new Random();
            string builder = string.Empty;
            for (int i = 0; i < rnd.Next(7); i++)
            {
                builder += words[rnd.Next(words.Count)] + " ";
            }

            return builder.Trim();
        }
    }
}

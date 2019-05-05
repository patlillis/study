﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;

namespace Study.Tests
{
	public static class Utils
	{
		public static List<T> Shuffle<T>(List<T> arr)
		{
			Random r = new Random();

			List<KeyValuePair<int, T>> list = new List<KeyValuePair<int, T>>();

			// Add all strings from array
			// Add new random int each time
			foreach (T t in arr)
			{
				list.Add(new KeyValuePair<int, T>(r.Next(), t));
			}

			// Sort the list by the random number
			var sorted = list.OrderBy(l => l.Key).ToList();

			// Allocate new string array
			List<T> result = new List<T>();

			// Copy values to array
			foreach (var item in sorted)
			{
				result.Add(item.Value);
			}

			// Return copied array
			return result;
		}

		public static readonly List<string> Words = new List<string>
		{
			"abandon",
			"abandoned",
			"abducted",
			"abduction",
			"abductions",
			"abhor",
			"abhorred",
			"abhorrent",
			"abhors",
			"abilities",
			"ability",
			"aboard",
			"absentee",
			"absentees",
			"absolve",
			"absolved",
			"absolves",
			"absolving",
			"absorbed",
			"abuse",
			"abused",
			"abuses",
			"abusive",
			"accept",
			"accepted",
			"accepting",
			"accepts",
			"accident",
			"accidental",
			"accidentally",
			"accidents",
			"accomplish",
			"accomplished",
			"accomplishes",
			"accusation",
			"accusations",
			"accuse",
			"accused",
			"accuses",
			"accusing",
			"ache",
			"achievable",
			"aching",
			"acquit",
			"acquits",
			"acquitted",
			"acquitting",
			"acrimonious",
			"active",
			"adequate",
			"admire",
			"admired",
			"admires",
			"admiring",
			"admit",
			"admits",
			"admitted",
			"admonish",
			"admonished",
			"adopt",
			"adopts",
			"adorable",
			"adore",
			"adored",
			"adores",
			"advanced",
			"advantage",
			"advantages",
			"adventure",
			"adventures",
			"adventurous",
			"affected",
			"affection",
			"affectionate",
			"afflicted",
			"affronted",
			"afraid",
			"aggravate",
			"aggravated",
			"aggravates",
			"aggravating",
			"aggression",
			"aggressions",
			"aggressive",
			"aghast",
			"agog",
			"agonise",
			"agonised",
			"agonises",
			"agonising",
			"agonize",
			"agonized",
			"agonizes",
			"agonizing",
			"agree",
			"agreeable",
			"agreed",
			"agreement",
			"agrees",
			"alarm",
			"alarmed",
			"alarmist",
			"alarmists",
			"alas",
			"alert",
			"alienation",
			"alive",
			"allergic",
			"allow",
			"alone",
			"amaze",
			"amazed",
			"amazes",
			"amazing",
			"ambitious",
			"ambivalent",
			"amuse",
			"amused",
			"amusement",
			"amusements",
			"anger",
			"angers",
			"angry",
			"anguish",
			"anguished",
			"animosity",
			"annoy",
			"annoyance",
			"annoyed",
			"annoying",
			"annoys",
			"antagonistic",
			"anti",
			"anticipation",
			"anxiety",
			"anxious",
			"apathetic",
			"apathy",
			"apeshit",
			"apocalyptic",
			"apologise",
			"apologised",
			"apologises",
			"apologising",
			"apologize",
			"apologized",
			"apologizes",
			"apologizing",
			"apology",
			"appalled",
			"appalling",
			"appease",
			"appeased",
			"appeases",
			"appeasing",
			"applaud",
			"applauded",
			"applauding",
			"applauds",
			"applause",
			"appreciate",
			"appreciated",
			"appreciates",
			"appreciating",
			"appreciation",
			"apprehensive",
			"approval",
			"approved",
			"approves",
			"ardent",
			"arrest",
			"arrested",
			"arrests",
			"arrogant",
			"ashame",
			"ashamed",
			"assassination",
			"assassinations",
			"asset",
			"assets",
			"assfucking",
			"astonished",
			"astound",
			"astounded",
			"astounding",
			"astoundingly",
			"astounds",
			"attack",
			"attacked",
			"attacking",
			"attacks",
			"attract",
			"attracted",
			"attracting",
			"attraction",
			"attractions",
			"attracts",
			"audacious",
			"authority",
			"avert",
			"averted",
			"averts",
			"avid",
			"avoid",
			"avoided",
			"avoids",
			"await",
			"awaited",
			"awaits",
			"award",
			"awarded",
			"awards",
			"awesome",
			"awful",
			"awkward",
			"axe",
			"axed",
			"abandons",
			"backing",
			"backs",
			"badass",
			"badly",
			"bailout",
			"bamboozle",
			"bamboozled",
			"bamboozles",
			"ban",
			"banish",
			"bankrupt",
			"bankster",
			"banned",
			"bargain",
			"barrier",
			"bastards",
			"battle",
			"battles",
			"beaten",
			"beatific",
			"beating",
			"beauties",
			"beautiful",
			"beautifully",
			"beautify",
			"belittle",
			"belittled",
			"beloved",
			"benefit",
			"benefits",
			"benefitted",
			"benefitting",
			"bereave",
			"bereaved",
			"bereaves",
			"bereaving",
			"best",
			"betray",
			"betrayal",
			"betrayed",
			"betraying",
			"betrays",
			"better",
			"bias",
			"biased",
			"big",
			"bitter",
			"bitterly",
			"bizarre",
			"blah",
			"blame",
			"blamed",
			"blames",
			"blaming",
			"bless",
			"blesses",
			"blessing",
			"blind",
			"bliss",
			"blissful",
			"blithe",
			"block",
			"blockbuster",
			"blocked",
			"blocking",
			"blocks",
			"bloody",
			"blurry",
			"boastful",
			"bold",
			"boldly",
			"boost",
			"boosted",
			"boosting",
			"boosts",
			"bore",
			"bored",
			"boring",
			"bother",
			"bothered",
			"bothers",
			"bothersome",
			"boycott",
			"boycotted",
			"boycotting",
			"boycotts",
			"brainwashing",
			"brave",
			"breakthrough",
			"breathtaking",
			"bribe",
			"bright",
			"brightest",
			"brightness",
			"brilliant",
			"brisk",
			"broke",
			"broken",
			"brooding",
			"bullied",
			"bully",
			"bullying",
			"bummer",
			"buoyant",
			"burden",
			"burdened",
			"burdening",
			"burdens",
			"backed",
			"bad",
			"committed",
			"calming",
			"cancel",
			"cancelled",
			"cancelling",
			"cancels",
			"capable",
			"captivated",
			"care",
			"carefree",
			"careful",
			"carefully",
			"careless",
			"cares",
			"casualty",
			"catastrophe",
			"catastrophic",
			"cautious",
			"celebrate",
			"celebrated",
			"celebrates",
			"celebrating",
			"censor",
			"censored",
			"censors",
			"certain",
			"chagrin",
			"chagrined",
			"challenge",
			"chance",
			"chances",
			"chaos",
			"chaotic",
			"charged",
			"charges",
			"charm",
			"charming",
			"charmless",
			"chastise",
			"chastised",
			"chastises",
			"chastising",
			"cheat",
			"cheated",
			"cheater",
			"cheaters",
			"cheats",
			"calmed",
			"cheered",
			"cheerful",
			"cheering",
			"cheerless",
			"cheers",
			"cheery",
			"cherish",
			"cherished",
			"cherishes",
			"cherishing",
			"chic",
			"childish",
			"chilling",
			"choke",
			"choked",
			"chokes",
			"choking",
			"clarifies",
			"clarity",
			"clash",
			"classy",
			"clean",
			"cleaner",
			"clear",
			"cleared",
			"clearly",
			"clears",
			"clever",
			"clouded",
			"clueless",
			"cocksuckers",
			"coerced",
			"collapse",
			"collapsed",
			"collapses",
			"collapsing",
			"collide",
			"collides",
			"colliding",
			"collision",
			"collisions",
			"colluding",
			"combat",
			"combats",
			"comedy",
			"comfort",
			"comfortable",
			"comforting",
			"comforts",
			"commend",
			"commended",
			"commit",
			"commitment",
			"commits",
			"calms",
			"committing",
			"compassionate",
			"compelled",
			"competent",
			"competitive",
			"complacent",
			"complain",
			"complained",
			"complains",
			"comprehensive",
			"conciliate",
			"conciliated",
			"conciliates",
			"conciliating",
			"condemn",
			"condemnation",
			"condemned",
			"condemns",
			"confidence",
			"confident",
			"conflict",
			"conflicting",
			"conflictive",
			"conflicts",
			"confuse",
			"confused",
			"confusing",
			"congrats",
			"congratulate",
			"congratulation",
			"congratulations",
			"consent",
			"consents",
			"consolable",
			"constrained",
			"contagion",
			"contagions",
			"contagious",
			"contempt",
			"contemptuous",
			"contemptuously",
			"contend",
			"contender",
			"contending",
			"contentious",
			"contestable",
			"controversial",
			"controversially",
			"convince",
			"convinced",
			"convinces",
			"convivial",
			"cool",
			"cornered",
			"corpse",
			"costly",
			"courage",
			"courageous",
			"courteous",
			"courtesy",
			"coward",
			"cowardly",
			"coziness",
			"cramp",
			"crash",
			"crazier",
			"craziest",
			"crazy",
			"creative",
			"crestfallen",
			"cried",
			"cries",
			"crime",
			"criminal",
			"criminals",
			"crisis",
			"critic",
			"criticism",
			"criticize",
			"criticized",
			"criticizes",
			"criticizing",
			"critics",
			"cruel",
			"cruelty",
			"crush",
			"crushed",
			"crushes",
			"crushing",
			"cry",
			"crying",
			"curious",
			"curse",
			"cut",
			"cute",
			"cuts",
			"cutting",
			"cynic",
			"cynical",
			"cynicism",
			"calm",
			"cheer",
			"damages",
			"damned",
			"danger",
			"daredevil",
			"daring",
			"darkest",
			"darkness",
			"dauntless",
			"dead",
			"deadlock",
			"deafening",
			"dear",
			"dearly",
			"death",
			"debonair",
			"debt",
			"deceit",
			"deceitful",
			"deceive",
			"deceived",
			"deceives",
			"deceiving",
			"deception",
			"decisive",
			"dedicated",
			"defeated",
			"defect",
			"defects",
			"defender",
			"defenders",
			"defenseless",
			"defer",
			"deferring",
			"defiant",
			"deficit",
			"degrade",
			"degraded",
			"degrades",
			"dehumanize",
			"dehumanized",
			"dehumanizes",
			"dehumanizing",
			"deject",
			"dejected",
			"dejecting",
			"dejects",
			"delay",
			"delayed",
			"delight",
			"delighted",
			"delighting",
			"delights",
			"demand",
			"demanded",
			"demanding",
			"demands",
			"demonstration",
			"demoralized",
			"denied",
			"denier",
			"deniers",
			"denies",
			"denounce",
			"denounces",
			"deny",
			"denying",
			"depressed",
			"depressing",
			"derail",
			"derailed",
			"derails",
			"deride",
			"derided",
			"derides",
			"deriding",
			"derision",
			"desirable",
			"desire",
			"desired",
			"desirous",
			"damage",
			"despairing",
			"despairs",
			"desperate",
			"desperately",
			"despondent",
			"destroy",
			"destroyed",
			"destroying",
			"destroys",
			"destruction",
			"destructive",
			"detached",
			"detain",
			"detained",
			"detention",
			"determined",
			"devastate",
			"devastated",
			"devastating",
			"devoted",
			"diamond",
			"die",
			"died",
			"difficult",
			"diffident",
			"dilemma",
			"dire",
			"direful",
			"dirt",
			"dirtier",
			"dirtiest",
			"dirty",
			"disabling",
			"disadvantage",
			"disadvantaged",
			"disappear",
			"disappeared",
			"disappears",
			"disappoint",
			"disappointed",
			"disappointing",
			"disappointment",
			"disappointments",
			"disappoints",
			"disaster",
			"disasters",
			"disastrous",
			"disbelieve",
			"discard",
			"discarded",
			"discarding",
			"discards",
			"disconsolate",
			"disconsolation",
			"discontented",
			"discord",
			"discounted",
			"discouraged",
			"discredited",
			"disdain",
			"disgrace",
			"disgraced",
			"disguise",
			"disguised",
			"disguises",
			"disguising",
			"disgust",
			"disgusted",
			"disgusting",
			"disheartened",
			"dishonest",
			"disillusioned",
			"disinclined",
			"disjointed",
			"dislike",
			"dismal",
			"dismayed",
			"disorder",
			"disorganized",
			"disoriented",
			"disparage",
			"disparaged",
			"disparages",
			"disparaging",
			"displeased",
			"dispute",
			"disputed",
			"disputes",
			"disputing",
			"disqualified",
			"disquiet",
			"disregard",
			"disregarded",
			"disregarding",
			"disregards",
			"disrespect",
			"disrespected",
			"disruption",
			"disruptions",
			"disruptive",
			"dissatisfied",
			"distort",
			"distorted",
			"distorting",
			"distorts",
			"distract",
			"distracted",
			"distraction",
			"distracts",
			"distress",
			"distressed",
			"distresses",
			"distressing",
			"distrust",
			"distrustful",
			"disturb",
			"disturbing",
			"disturbs",
			"dithering",
			"dizzy",
			"dodging",
			"dodgy",
			"dolorous",
			"doom",
			"doomed",
			"doubt",
			"doubted",
			"doubtful",
			"doubting",
			"doubts",
			"douche",
			"douchebag",
			"downcast",
			"downhearted",
			"downside",
			"drag",
			"dragged",
			"drags",
			"drained",
			"dread",
			"dreaded",
			"dreadful",
			"dreading",
			"dream",
			"dreams",
			"dreary",
			"droopy",
			"drop",
			"drown",
			"drowned",
			"drowns",
			"dubious",
			"dud",
			"dull",
			"dump",
			"dumped",
			"dumps",
			"dupe",
			"duped",
			"dysfunction",
			"despair",
			"eager",
			"ease",
			"easy",
			"ecstatic",
			"eerie",
			"eery",
			"effective",
			"effectively",
			"elated",
			"elation",
			"elegant",
			"elegantly",
			"embarrass",
			"embarrassed",
			"embarrasses",
			"embarrassing",
			"embarrassment",
			"embittered",
			"embrace",
			"emergency",
			"empathetic",
			"emptiness",
			"empty",
			"enchanted",
			"encourage",
			"encouraged",
			"encouragement",
			"encourages",
			"endorse",
			"endorsed",
			"endorsement",
			"endorses",
			"enemies",
			"energetic",
			"engage",
			"engages",
			"engrossed",
			"enjoy",
			"enjoying",
			"enjoys",
			"enlighten",
			"enlightened",
			"enlightening",
			"enlightens",
			"ennui",
			"enrage",
			"enraged",
			"enrages",
			"enraging",
			"enrapture",
			"enslave",
			"enslaved",
			"enslaves",
			"ensure",
			"ensuring",
			"enterprising",
			"entertaining",
			"enthral",
			"enthusiastic",
			"entitled",
			"entrusted",
			"envies",
			"envious",
			"envy",
			"envying",
			"erroneous",
			"error",
			"errors",
			"escape",
			"escapes",
			"escaping",
			"esteemed",
			"ethical",
			"euphoria",
			"euphoric",
			"eviction",
			"evil",
			"exaggerate",
			"exaggerated",
			"exaggerates",
			"exaggerating",
			"exasperated",
			"excellence",
			"excellent",
			"excite",
			"excited",
			"excitement",
			"exciting",
			"exclude",
			"excluded",
			"exclusion",
			"exclusive",
			"excuse",
			"exempt",
			"exhausted",
			"exhilarated",
			"exhilarates",
			"exhilarating",
			"exonerate",
			"exonerated",
			"exonerates",
			"exonerating",
			"expand",
			"expands",
			"expel",
			"expelled",
			"expelling",
			"expels",
			"exploit",
			"exploited",
			"exploiting",
			"exploits",
			"exploration",
			"explorations",
			"expose",
			"exposed",
			"exposes",
			"exposing",
			"extend",
			"extends",
			"exuberant",
			"exultant",
			"exultantly",
			"earnest",
			"fad",
			"fraudster",
			"faggots",
			"fail",
			"failed",
			"failing",
			"fails",
			"failure",
			"failures",
			"fainthearted",
			"fair",
			"faith",
			"faithful",
			"fake",
			"fakes",
			"faking",
			"fallen",
			"falling",
			"falsified",
			"falsify",
			"fame",
			"fan",
			"fantastic",
			"farce",
			"fascinate",
			"fascinated",
			"fascinates",
			"fascinating",
			"fascist",
			"fascists",
			"fatalities",
			"fatality",
			"fatigue",
			"fatigued",
			"fatigues",
			"fatiguing",
			"favor",
			"favored",
			"favorite",
			"favorited",
			"favorites",
			"favors",
			"fear",
			"fearful",
			"fearing",
			"fearless",
			"fearsome",
			"feeble",
			"feeling",
			"felonies",
			"felony",
			"fervent",
			"fervid",
			"festive",
			"fiasco",
			"fidgety",
			"fight",
			"fine",
			"fire",
			"fired",
			"firing",
			"fit",
			"fitness",
			"flagship",
			"flees",
			"flop",
			"flops",
			"flu",
			"flustered",
			"focused",
			"fond",
			"fondness",
			"fool",
			"foolish",
			"fools",
			"forced",
			"foreclosure",
			"foreclosures",
			"forget",
			"forgetful",
			"forgive",
			"forgiving",
			"forgotten",
			"fortunate",
			"frantic",
			"fraud",
			"frauds",
			"fabulous",
			"fraudsters",
			"fraudulence",
			"fraudulent",
			"free",
			"freedom",
			"frenzy",
			"fresh",
			"friendly",
			"fright",
			"frightened",
			"frightening",
			"frikin",
			"frisky",
			"frowning",
			"frustrate",
			"frustrated",
			"frustrates",
			"frustrating",
			"frustration",
			"ftw",
			"fud",
			"fuked",
			"fuking",
			"fulfill",
			"fulfilled",
			"fulfills",
			"fuming",
			"fun",
			"funeral",
			"funerals",
			"funky",
			"funnier",
			"funny",
			"furious",
			"futile",
			"gagged",
			"gloom",
			"gained",
			"gaining",
			"gains",
			"gallant",
			"gallantly",
			"gallantry",
			"generous",
			"genial",
			"ghost",
			"giddy",
			"gift",
			"glad",
			"glamorous",
			"glamourous",
			"glee",
			"gleeful",
			"gag",
			"gloomy",
			"glorious",
			"glory",
			"glum",
			"godsend",
			"good",
			"goodness",
			"grace",
			"gracious",
			"grand",
			"grant",
			"granted",
			"granting",
			"grants",
			"grateful",
			"gratification",
			"grave",
			"gray",
			"great",
			"greater",
			"greatest",
			"greed",
			"greedy",
			"greenwash",
			"greenwasher",
			"greenwashers",
			"greenwashing",
			"greet",
			"greeted",
			"greeting",
			"greetings",
			"greets",
			"grey",
			"grief",
			"grieved",
			"growing",
			"growth",
			"guarantee",
			"guilt",
			"guilty",
			"gullibility",
			"gullible",
			"gun",
			"gain",
			"hid",
			"hacked",
			"hahaha",
			"hahahah",
			"hail",
			"hailed",
			"hapless",
			"haplessness",
			"happiness",
			"happy",
			"hard",
			"hardier",
			"hardship",
			"hardy",
			"harm",
			"harmed",
			"harmful",
			"ha",
			"harms",
			"harried",
			"harsh",
			"harsher",
			"harshest",
			"hate",
			"hated",
			"haters",
			"hates",
			"hating",
			"haunt",
			"haunted",
			"haunting",
			"haunts",
			"havoc",
			"healthy",
			"heartbreaking",
			"heartbroken",
			"heartfelt",
			"heaven",
			"heavenly",
			"heavyhearted",
			"help",
			"helpful",
			"helping",
			"helpless",
			"helps",
			"hero",
			"heroes",
			"heroic",
			"hesitant",
			"hesitate",
			"haha",
			"hide",
			"hides",
			"hiding",
			"highlight",
			"hilarious",
			"hindrance",
			"hoax",
			"homesick",
			"honest",
			"honor",
			"honored",
			"honoring",
			"honour",
			"honoured",
			"honouring",
			"hooligan",
			"hooliganism",
			"hooligans",
			"hope",
			"hopeful",
			"hopefully",
			"hopeless",
			"hopelessness",
			"hopes",
			"hoping",
			"horrendous",
			"horrible",
			"horrific",
			"horrified",
			"hostile",
			"huckster",
			"hug",
			"huge",
			"hugs",
			"humerous",
			"humiliated",
			"humiliation",
			"humor",
			"humorous",
			"humour",
			"humourous",
			"hunger",
			"hurrah",
			"hurt",
			"hurting",
			"hurts",
			"hypocritical",
			"hysteria",
			"hysterical",
			"hysterics",
			"harming",
			"idiotic",
			"ignorance",
			"ignorant",
			"ignore",
			"ignored",
			"ignores",
			"ill",
			"illegal",
			"illiteracy",
			"illness",
			"illnesses",
			"imbecile",
			"immobilized",
			"immortal",
			"immune",
			"impatient",
			"imperfect",
			"importance",
			"important",
			"impose",
			"imposed",
			"imposes",
			"imposing",
			"impotent",
			"impress",
			"impressed",
			"impresses",
			"impressive",
			"imprisoned",
			"improve",
			"improved",
			"improvement",
			"improves",
			"improving",
			"inability",
			"inaction",
			"inadequate",
			"incapable",
			"incapacitated",
			"incensed",
			"incompetence",
			"incompetent",
			"inconsiderate",
			"inconvenience",
			"inconvenient",
			"increase",
			"increased",
			"indecisive",
			"indestructible",
			"indifference",
			"indifferent",
			"indignant",
			"indignation",
			"indoctrinate",
			"indoctrinated",
			"indoctrinates",
			"indoctrinating",
			"ineffective",
			"ineffectively",
			"infatuated",
			"infatuation",
			"infected",
			"inferior",
			"inflamed",
			"influential",
			"infringement",
			"infuriate",
			"infuriated",
			"infuriates",
			"infuriating",
			"inhibit",
			"injured",
			"injury",
			"injustice",
			"innovate",
			"innovates",
			"innovation",
			"innovative",
			"inquisition",
			"inquisitive",
			"insane",
			"insanity",
			"insecure",
			"insensitive",
			"insensitivity",
			"insignificant",
			"insipid",
			"inspiration",
			"inspirational",
			"inspire",
			"inspired",
			"inspires",
			"inspiring",
			"insult",
			"insulted",
			"insulting",
			"insults",
			"intact",
			"integrity",
			"intelligent",
			"intense",
			"interest",
			"interested",
			"interesting",
			"interests",
			"interrogated",
			"interrupt",
			"interrupted",
			"interrupting",
			"interruption",
			"interrupts",
			"intimidate",
			"intimidated",
			"intimidates",
			"intimidating",
			"intimidation",
			"intricate",
			"intrigues",
			"invincible",
			"invite",
			"inviting",
			"invulnerable",
			"irate",
			"ironic",
			"irony",
			"irrational",
			"irresistible",
			"irresolute",
			"irresponsible",
			"irreversible",
			"irritate",
			"irritated",
			"irritating",
			"isolated",
			"itchy",
			"jackasses",
			"jaunty",
			"jealous",
			"jeopardy",
			"jerk",
			"jewel",
			"jewels",
			"jocular",
			"join",
			"joke",
			"jokes",
			"jolly",
			"jovial",
			"joy",
			"joyful",
			"joyfully",
			"joyless",
			"joyous",
			"jubilant",
			"jumpy",
			"justice",
			"justifiably",
			"justified",
			"jailed",
			"kill",
			"killed",
			"kind",
			"kinder",
			"kiss",
			"kudos",
			"keen",
			"loathe",
			"lag",
			"lags",
			"lame",
			"landmark",
			"laugh",
			"laughed",
			"laughing",
			"laughs",
			"laughting",
			"launched",
			"lawl",
			"lawsuit",
			"lawsuits",
			"lazy",
			"leak",
			"leaked",
			"leave",
			"legal",
			"legally",
			"lenient",
			"lethargic",
			"lethargy",
			"liar",
			"liars",
			"libelous",
			"lied",
			"lifesaver",
			"lighthearted",
			"like",
			"liked",
			"likes",
			"limitation",
			"limited",
			"limits",
			"litigation",
			"litigious",
			"lively",
			"livid",
			"lmao",
			"lmfao",
			"lagging",
			"loathed",
			"loathes",
			"loathing",
			"lobby",
			"lobbying",
			"lol",
			"lonely",
			"lonesome",
			"longing",
			"loom",
			"loomed",
			"looming",
			"looms",
			"loose",
			"looses",
			"losing",
			"loss",
			"lost",
			"lovable",
			"love",
			"loved",
			"lovelies",
			"lovely",
			"loving",
			"lowest",
			"loyal",
			"loyalty",
			"luck",
			"luckily",
			"lucky",
			"lugubrious",
			"lunatic",
			"lunatics",
			"lurk",
			"lurking",
			"lurks",
			"lackadaisical",
			"lagged",
			"lack",
			"madly",
			"madness",
			"mandatory",
			"manipulated",
			"manipulating",
			"manipulation",
			"marvel",
			"marvelous",
			"marvels",
			"masterpiece",
			"masterpieces",
			"matter",
			"matters",
			"mature",
			"meaningful",
			"meaningless",
			"medal",
			"mediocrity",
			"meditative",
			"melancholy",
			"menace",
			"menaced",
			"mercy",
			"mess",
			"messed",
			"methodical",
			"mindless",
			"miracle",
			"mirth",
			"mirthful",
			"mirthfully",
			"misbehave",
			"misbehaved",
			"misbehaves",
			"misbehaving",
			"mischief",
			"mischiefs",
			"miserable",
			"misery",
			"misgiving",
			"misinformation",
			"misinformed",
			"misinterpreted",
			"misleading",
			"misread",
			"misreporting",
			"misrepresentation",
			"miss",
			"missed",
			"missing",
			"mistake",
			"mistaken",
			"mistakes",
			"mistaking",
			"misunderstand",
			"misunderstanding",
			"misunderstands",
			"misunderstood",
			"moan",
			"moaned",
			"moaning",
			"moans",
			"mock",
			"mocked",
			"mocking",
			"mocks",
			"mongering",
			"monopolize",
			"monopolized",
			"monopolizes",
			"monopolizing",
			"moody",
			"mope",
			"moping",
			"motivate",
			"motivated",
			"motivating",
			"motivation",
			"mourn",
			"mourned",
			"mournful",
			"mourning",
			"mourns",
			"mumpish",
			"murdering",
			"murderous",
			"murders",
			"myth",
			"maddening",
			"merry",
			"naive",
			"natural",
			"needy",
			"negative",
			"negativity",
			"neglect",
			"neglected",
			"neglecting",
			"neglects",
			"nerves",
			"nervous",
			"nervously",
			"nice",
			"nifty",
			"nasty",
			"no",
			"noble",
			"noisy",
			"nonsense",
			"noob",
			"nosey",
			"notorious",
			"novel",
			"numb",
			"nuts",
			"obliterated",
			"obnoxious",
			"obscene",
			"obsessed",
			"obsolete",
			"obstacle",
			"obstacles",
			"obstinate",
			"odd",
			"offend",
			"offended",
			"offender",
			"offending",
			"offends",
			"offline",
			"oks",
			"ominous",
			"opportunities",
			"opportunity",
			"oppressed",
			"oppressive",
			"optimism",
			"optimistic",
			"optionless",
			"outcry",
			"outmaneuvered",
			"outrage",
			"outraged",
			"outreach",
			"outstanding",
			"overjoyed",
			"overload",
			"overlooked",
			"overreact",
			"overreacted",
			"overreaction",
			"overreacts",
			"oversell",
			"overselling",
			"oversells",
			"oversimplification",
			"oversimplified",
			"oversimplifies",
			"oversimplify",
			"overstatement",
			"overstatements",
			"overweight",
			"oxymoron",
			"obliterate",
			"punished",
			"pained",
			"panicked",
			"pain",
			"paradise",
			"paradox",
			"pardon",
			"pardoned",
			"pardoning",
			"pardons",
			"parley",
			"passionate",
			"passive",
			"passively",
			"pathetic",
			"pay",
			"peace",
			"peaceful",
			"peacefully",
			"penalty",
			"pensive",
			"perfect",
			"perfected",
			"perfectly",
			"perfects",
			"peril",
			"perjury",
			"perpetrator",
			"perpetrators",
			"perplexed",
			"persecute",
			"persecuted",
			"persecutes",
			"persecuting",
			"perturbed",
			"pesky",
			"pessimism",
			"pessimistic",
			"petrified",
			"phobic",
			"picturesque",
			"pileup",
			"pique",
			"piqued",
			"piteous",
			"pitied",
			"pity",
			"playful",
			"pleasant",
			"please",
			"pleased",
			"pleasure",
			"poised",
			"poison",
			"poisoned",
			"poisons",
			"pollute",
			"polluted",
			"polluter",
			"polluters",
			"pollutes",
			"poor",
			"poorer",
			"poorest",
			"popular",
			"positive",
			"positively",
			"possessive",
			"postpone",
			"postponed",
			"postpones",
			"postponing",
			"poverty",
			"powerful",
			"powerless",
			"praise",
			"praised",
			"praises",
			"praising",
			"pray",
			"praying",
			"prays",
			"prblm",
			"prblms",
			"prepared",
			"pressure",
			"pressured",
			"pretend",
			"pretending",
			"pretends",
			"pretty",
			"prevent",
			"prevented",
			"preventing",
			"prevents",
			"prison",
			"prisoner",
			"prisoners",
			"privileged",
			"proactive",
			"problem",
			"problems",
			"profiteer",
			"progress",
			"prominent",
			"promise",
			"promised",
			"promises",
			"promote",
			"promoted",
			"promotes",
			"promoting",
			"prosecute",
			"prosecuted",
			"prosecutes",
			"prosecution",
			"prospect",
			"prospects",
			"prosperous",
			"protect",
			"protected",
			"protects",
			"protest",
			"protesters",
			"protesting",
			"protests",
			"proud",
			"proudly",
			"provoke",
			"provoked",
			"provokes",
			"provoking",
			"pseudoscience",
			"punish",
			"panic",
			"punishes",
			"punitive",
			"pushy",
			"puzzled",
			"panics",
			"quaking",
			"questioned",
			"questioning",
			"questionable",
			"resign",
			"racist",
			"rage",
			"rageful",
			"rainy",
			"rant",
			"ranter",
			"ranters",
			"rants",
			"rapture",
			"raptured",
			"raptures",
			"rapturous",
			"rash",
			"ratified",
			"reach",
			"reached",
			"reaches",
			"reaching",
			"reassure",
			"reassured",
			"reassures",
			"reassuring",
			"rebellion",
			"recession",
			"reckless",
			"recommend",
			"recommended",
			"recommends",
			"redeemed",
			"refuse",
			"refused",
			"refusing",
			"regret",
			"regretful",
			"regrets",
			"regretted",
			"regretting",
			"reject",
			"rejected",
			"rejecting",
			"rejects",
			"rejoice",
			"rejoiced",
			"rejoices",
			"rejoicing",
			"relaxed",
			"relentless",
			"reliant",
			"relieve",
			"relieved",
			"relieves",
			"relieving",
			"relishing",
			"remarkable",
			"remorse",
			"repulse",
			"repulsed",
			"rescue",
			"rescued",
			"racism",
			"resentful",
			"racists",
			"resigned",
			"resigning",
			"resigns",
			"resolute",
			"resolve",
			"resolved",
			"resolves",
			"resolving",
			"respected",
			"responsible",
			"responsive",
			"restful",
			"restless",
			"restore",
			"restored",
			"restores",
			"restoring",
			"restrict",
			"restricted",
			"restricting",
			"restriction",
			"restricts",
			"retained",
			"retreat",
			"revenge",
			"revengeful",
			"revered",
			"revive",
			"revives",
			"reward",
			"rewarded",
			"rewarding",
			"rewards",
			"rich",
			"ridiculous",
			"rig",
			"rigged",
			"rigorous",
			"rigorously",
			"riot",
			"riots",
			"risk",
			"risks",
			"rob",
			"robed",
			"robing",
			"robs",
			"robust",
			"rofl",
			"roflcopter",
			"roflmao",
			"romance",
			"rotfl",
			"rotflmfao",
			"rotflol",
			"ruin",
			"ruined",
			"ruining",
			"ruins",
			"rescues",
			"sabotage",
			"sad",
			"sadden",
			"saddened",
			"sadly",
			"safe",
			"safely",
			"safety",
			"salient",
			"sappy",
			"sarcastic",
			"satisfied",
			"save",
			"saved",
			"scam",
			"scams",
			"scandal",
			"scandalous",
			"scandals",
			"scapegoat",
			"scapegoats",
			"scare",
			"scared",
			"scary",
			"sceptical",
			"scold",
			"scoop",
			"scorn",
			"scornful",
			"scream",
			"screamed",
			"screaming",
			"screams",
			"screwed",
			"scumbag",
			"secure",
			"secured",
			"secures",
			"sedition",
			"seditious",
			"seduced",
			"selfish",
			"selfishness",
			"sentence",
			"sentenced",
			"sentences",
			"sentencing",
			"serene",
			"severe",
			"shaky",
			"shame",
			"shamed",
			"shameful",
			"share",
			"shared",
			"shares",
			"shattered",
			"shock",
			"shocked",
			"shocking",
			"shocks",
			"shortage",
			"shortages",
			"shrew",
			"shy",
			"sigh",
			"significance",
			"significant",
			"silencing",
			"silly",
			"sincere",
			"sincerely",
			"sincerest",
			"sincerity",
			"sinful",
			"singleminded",
			"skeptic",
			"skeptical",
			"skepticism",
			"skeptics",
			"slam",
			"slash",
			"slashed",
			"slashes",
			"slashing",
			"slavery",
			"sleeplessness",
			"slick",
			"slicker",
			"slickest",
			"sluggish",
			"smart",
			"smarter",
			"smartest",
			"smear",
			"smile",
			"smiled",
			"smiles",
			"smiling",
			"smog",
			"sneaky",
			"snub",
			"snubbed",
			"snubbing",
			"snubs",
			"sobering",
			"solemn",
			"solid",
			"solidarity",
			"solution",
			"solutions",
			"solve",
			"solved",
			"solves",
			"solving",
			"somber",
			"soothe",
			"soothed",
			"soothing",
			"sophisticated",
			"sore",
			"sorrow",
			"sorrowful",
			"sorry",
			"spam",
			"spammer",
			"spammers",
			"spamming",
			"spark",
			"sparkle",
			"sparkles",
			"sparkling",
			"speculative",
			"spirit",
			"spirited",
			"spiritless",
			"spiteful",
			"splendid",
			"sprightly",
			"squelched",
			"stab",
			"stabbed",
			"stable",
			"stabs",
			"stall",
			"stalled",
			"stalling",
			"stamina",
			"stampede",
			"startled",
			"starve",
			"starved",
			"starves",
			"starving",
			"steadfast",
			"steal",
			"steals",
			"stereotype",
			"stereotyped",
			"stifled",
			"stimulate",
			"stimulated",
			"stimulates",
			"stimulating",
			"stingy",
			"stolen",
			"stop",
			"stopped",
			"stopping",
			"stops",
			"stout",
			"straight",
			"strange",
			"strangely",
			"strangled",
			"strength",
			"strengthen",
			"strengthened",
			"strengthening",
			"strengthens",
			"stressed",
			"stressor",
			"stressors",
			"stricken",
			"strike",
			"strikers",
			"strikes",
			"strong",
			"stronger",
			"strongest",
			"struck",
			"struggle",
			"struggled",
			"struggles",
			"struggling",
			"stubborn",
			"stuck",
			"stunned",
			"stunning",
			"stupidly",
			"suave",
			"substantial",
			"substantially",
			"subversive",
			"success",
			"successful",
			"sucks",
			"suffer",
			"suffering",
			"suffers",
			"suicidal",
			"suing",
			"sulking",
			"sulky",
			"sullen",
			"sunshine",
			"super",
			"superb",
			"superior",
			"support",
			"supported",
			"supporter",
			"supporters",
			"supporting",
			"supportive",
			"supports",
			"survived",
			"surviving",
			"survivor",
			"suspect",
			"suspected",
			"suspecting",
			"suspects",
			"suspend",
			"suspended",
			"suspicious",
			"swear",
			"swearing",
			"swears",
			"sweet",
			"swift",
			"swiftly",
			"swindle",
			"swindles",
			"swindling",
			"sympathetic",
			"sympathy",
			"torn",
			"tense",
			"tension",
			"terrible",
			"terribly",
			"terrific",
			"terrified",
			"terror",
			"terrorize",
			"terrorized",
			"terrorizes",
			"thank",
			"thankful",
			"thanks",
			"thorny",
			"thoughtful",
			"thoughtless",
			"threat",
			"threaten",
			"threatened",
			"threatening",
			"threatens",
			"threats",
			"thrilled",
			"thwart",
			"thwarted",
			"thwarting",
			"thwarts",
			"timid",
			"timorous",
			"tired",
			"tolerant",
			"toothless",
			"top",
			"tops",
			"tender",
			"tortured",
			"tortures",
			"torturing",
			"totalitarian",
			"totalitarianism",
			"tout",
			"touted",
			"touting",
			"touts",
			"tragedy",
			"tragic",
			"tranquil",
			"trap",
			"trapped",
			"trauma",
			"traumatic",
			"travesty",
			"treason",
			"treasonous",
			"treasure",
			"treasures",
			"trembling",
			"tremulous",
			"tricked",
			"trickery",
			"triumph",
			"triumphant",
			"trouble",
			"troubled",
			"troubles",
			"true",
			"trust",
			"trusted",
			"tumor",
			"tears",
			"ugly",
			"unacceptable",
			"unappreciated",
			"unapproved",
			"unaware",
			"unbelievable",
			"unbelieving",
			"unbiased",
			"uncertain",
			"unclear",
			"uncomfortable",
			"unconcerned",
			"unconfirmed",
			"unconvinced",
			"uncredited",
			"undecided",
			"underestimate",
			"underestimated",
			"underestimates",
			"underestimating",
			"undermine",
			"undermined",
			"undermines",
			"undermining",
			"undeserving",
			"undesirable",
			"uneasy",
			"unemployment",
			"unequal",
			"unequaled",
			"unethical",
			"unfair",
			"unfocused",
			"unfulfilled",
			"unhappy",
			"unhealthy",
			"unified",
			"unimpressed",
			"unintelligent",
			"united",
			"unjust",
			"unlovable",
			"unloved",
			"unmatched",
			"unmotivated",
			"unprofessional",
			"unresearched",
			"unsatisfied",
			"unsecured",
			"unsettled",
			"unsophisticated",
			"unstable",
			"unstoppable",
			"unsupported",
			"unsure",
			"untarnished",
			"unwanted",
			"unworthy",
			"upset",
			"upsets",
			"upsetting",
			"uptight",
			"urgent",
			"useful",
			"usefulness",
			"useless",
			"uselessness",
			"vindicates",
			"vague",
			"validates",
			"validating",
			"verdict",
			"verdicts",
			"vested",
			"vexation",
			"vexing",
			"vibrant",
			"vicious",
			"victim",
			"victimize",
			"victimized",
			"victimizes",
			"victimizing",
			"victims",
			"vigilant",
			"vile",
			"vindicate",
			"vindicated",
			"validated",
			"vindicating",
			"violate",
			"violated",
			"violates",
			"violating",
			"violence",
			"violent",
			"virtuous",
			"virulent",
			"vision",
			"visionary",
			"visioning",
			"visions",
			"vitality",
			"vitamin",
			"vitriolic",
			"vivacious",
			"vociferous",
			"vulnerability",
			"vulnerable",
			"validate",
			"walkout",
			"walkouts",
			"want",
			"war",
			"warfare",
			"warm",
			"warmth",
			"warn",
			"warned",
			"warning",
			"warnings",
			"warns",
			"waste",
			"wasted",
			"wasting",
			"wavering",
			"weak",
			"weakness",
			"wealth",
			"wealthy",
			"weary",
			"weep",
			"weeping",
			"weird",
			"welcome",
			"welcomed",
			"welcomes",
			"whimsical",
			"whitewash",
			"wicked",
			"widowed",
			"willingness",
			"win",
			"winner",
			"winning",
			"wins",
			"winwin",
			"wish",
			"wishes",
			"wishing",
			"withdrawal",
			"woebegone",
			"woeful",
			"won",
			"wonderful",
			"woo",
			"woohoo",
			"wooo",
			"woow",
			"worn",
			"worried",
			"worry",
			"worrying",
			"worse",
			"worsen",
			"worsened",
			"worsening",
			"worsens",
			"worshiped",
			"worst",
			"worth",
			"worthless",
			"worthy",
			"wow",
			"wowow",
			"wowww",
			"wrathful",
			"wreck",
			"wrong",
			"wronged",
			"yeah",
			"yearning",
			"yeees",
			"yes",
			"youthful",
			"yucky",
			"yummy",
			"zealot",
			"zealots",
			"zealous",
			"kaleidoscope",
			"kangaroo",
			"kaput",
			"karat",
			"karate",
			"karma",
			"kayak",
			"keel",
			"keenly",
			"keenness",
			"keep",
			"keeper",
			"keeping",
			"keepsake",
			"keg",
			"kennel",
			"kept",
			"kernel",
			"kerosene",
			"ketchup",
			"kettle",
			"key",
			"keyboard",
			"keyhole",
			"keynote",
			"khaki",
			"khakis",
			"kick",
			"kickback",
			"kickoff",
			"kid",
			"kiddie",
			"kiddo",
			"kidnap",
			"kidnapper",
			"kidnapping",
			"kidney",
			"kiln",
			"kilo",
			"kilobyte",
			"kilogram",
			"kilometer",
			"kilowatt",
			"kilt",
			"kimono",
			"kin",
			"kindergarten",
			"kindergartner",
			"kindhearted",
			"kindle",
			"kindling",
			"kindly",
			"kindness",
			"kindred",
			"kinfolk",
			"king",
			"kingdom",
			"kingfisher",
			"kingpin",
			"kiosk",
			"kit",
			"kitchen",
			"kite",
			"kitten",
			"kitty",
			"kiwi",
			"kleenex",
			"kleptomaniac",
			"klutz",
			"klutzy",
			"knack",
			"knapsack",
			"knead",
			"knee",
			"kneecap",
			"kneel",
			"knelt",
			"knew",
			"knickers",
			"knickknack",
			"knife",
			"knight",
			"knit",
			"knitting",
			"knives",
			"knob",
			"knobby",
			"knock",
			"knocker",
			"knockout",
			"knoll",
			"knot",
			"knotty",
			"know",
			"knowing",
			"knowingly",
			"knowledge",
			"knowledgeable",
			"knowledgeably",
			"known",
			"knuckle",
			"koala",
			"kosher",
			"kowtow",
			"quack",
			"quad",
			"quadrangle",
			"quadrant",
			"quadrilateral",
			"quadruped",
			"quadruple",
			"quadruplet",
			"quagmire",
			"quail",
			"quaint",
			"quake",
			"qualification",
			"qualified",
			"qualifier",
			"qualify",
			"qualitative",
			"quality",
			"qualm",
			"quandary",
			"quantifier",
			"quantify",
			"quantitative",
			"quantity",
			"quarantine",
			"quark",
			"quarrel",
			"quarrelsome",
			"quarry",
			"quart",
			"quarter",
			"quarterback",
			"quarterfinal",
			"quarterly",
			"quarters",
			"quartet",
			"quartz",
			"quash",
			"quaver",
			"quay",
			"queasiness",
			"queasy",
			"queen",
			"quell",
			"quench",
			"query",
			"quest",
			"question",
			"questionnaire",
			"quibble",
			"quiche",
			"quick",
			"quicken",
			"quickly",
			"quicksand",
			"quiet",
			"quietly",
			"quietness",
			"quill",
			"quilt",
			"quintessence",
			"quintessential",
			"quintet",
			"quintuplet",
			"quip",
			"quirk",
			"quirky",
			"quit",
			"quite",
			"quits",
			"quitter",
			"quiver",
			"quixotic",
			"quiz",
			"quizzical",
			"quorum",
			"quota",
			"quotable",
			"quotation",
			"quote",
			"quotient",
			"xanax",
			"xenophobia",
			"xenophobic",
			"xerox",
			"xmas",
			"xylophone",
			"yacht",
			"yak",
			"yam",
			"yank",
			"yankee",
			"yap",
			"yard",
			"yardstick",
			"yarmulke",
			"yarn",
			"yawn",
			"year",
			"yearbook",
			"yearling",
			"yearly",
			"yearn",
			"years",
			"yeast",
			"yell",
			"yellow",
			"yellowish",
			"yelp",
			"yen",
			"yep",
			"yesterday",
			"yet",
			"yield",
			"yippee",
			"yo",
			"yodel",
			"yoga",
			"yogurt",
			"yoke",
			"yokel",
			"yolk",
			"yonder",
			"you",
			"young",
			"youngster",
			"your",
			"yours",
			"yourself",
			"yourselves",
			"youth",
			"yuck",
			"yuletide",
			"yum",
			"yuppie",
			"zany",
			"zap",
			"zeal",
			"zealously",
			"zebra",
			"zero",
			"zest",
			"zigzag",
			"zillion",
			"zinc",
			"zip",
			"zipper",
			"zit",
			"zodiac",
			"zombie",
			"zone",
			"zoo",
			"zoological",
			"zoologist",
			"zoology",
			"zoom",
			"zucchini"
		};
	}
}
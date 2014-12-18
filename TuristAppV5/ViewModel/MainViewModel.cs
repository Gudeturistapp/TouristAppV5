using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.Globalization;
using TuristAppV5.Annotations;
﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using TuristAppV5.Common;
using TuristAppV5.Model;

namespace TuristAppV5.ViewModel
{
    public class MainViewModel :INotifyPropertyChanged
    {
        //Properties
        #region Properties
        public static string LanguageFromFile { get; set; }

        public static Attractions SelectedAttraction { get; set; }
        public static Comments SelectedComments { get; set; }
        
        public AttractionList Restaurants { get; set; }
        public AttractionList Events { get; set; }
        public AttractionList Culture { get; set; }
        public AttractionList Shopping { get; set; }
        public string Comment { get; set; }
        #endregion

       public MainViewModel()
        {
            GetLanguage();
            Restaurants = new AttractionList();
            Events = new AttractionList();
            Culture = new AttractionList();
            Shopping = new AttractionList();
            DetailPageInfo();
        }

        public void DetailPageInfo()
        {
            #region Attributter
            string restaurentJensensBøfhus;
            string restaurentBones;
            string restaurentCafeVivaldi;
            string restaurentMumm;

            string eventRoskildeFestival;
            string eventLysfest;
            string eventHavnen;
            string eventMusicon;

            string shoppingsRoTorv;
            string shoppingsGaaGade;
            string shoppingskoebmand;
            string shoppingsBjergtrold;

            string attractionVikingeSkibsMuseum;
            string attractionRoskildeDomkirke;
            string attractionEtGallery;
            string attractionRaadhus;
            #endregion
            #region Text Definer
            if (LanguageFromFile.Equals("Danish"))
            {
                #region Danish version
                restaurentJensensBøfhus = @"Jensens Bøfhus er en utrolig hyggelig restaurant hvor man både som ny forelsket eller som et par med flere år bag sig 
har mulighed for at få en dejlig og fantastisk aften, med utrolig lækker mad og en virkelig god service. Jensens Bøfhus har i de sidste 10 år leveret denne fantastiske service til alle der besøger dem,
og de kan findes på:
tlf: 29432395

og har åbent:
alle hverdage: 17-22
lør-søn: 17-23";
                restaurentBones = @"Restauranten Bones er en utrolig hyggelig restaurant hvor man både som ny forelsket eller som et par med flere år bag sig 
har mulighed for at få en dejlig og fantastisk aften, med utrolig lækker mad og en virkelig god service. Bones har i de sidste 10 år leveret denne fantastiske service til alle der besøger dem,
og de kan findes på:
tlf: 29432395

og har åbent:
alle hverdage: 17-22
lør-søn: 17-23";
                restaurentCafeVivaldi = @"Café Vivaldi er en utrolig hyggelig restaurant hvor man både som ny forelsket eller som et par med flere år bag sig 
har mulighed for at få en dejlig og fantastisk aften, med utrolig lækker mad og en virkelig god service. Vivaldi har i de sidste 10 år leveret denne fantastiske service til alle der besøger dem,
og de kan findes på:
tlf: 29432395

og har åbent:
alle hverdage: 17-22
lør-søn: 17-23";
                restaurentMumm = @"Restauranten Mumm er en utrolig hyggelig restaurant hvor man både som ny forelsket eller som et par med flere år bag sig 
har mulighed for at få en dejlig og fantastisk aften, med utrolig lækker mad og en virkelig god service. Mumm har i de sidste 10 år leveret denne fantastiske service til alle der besøger dem,
og de kan findes på:
tlf: 29432395

og har åbent:
alle hverdage: 17-22
lør-søn: 17-23";

                eventRoskildeFestival = @"Roskilde Festivalen er en af de største seværdigheder i Roskilde, og tiltrækker flere tusinder af mennesker til byen hvert år for denne
fantastiske begivenhed, Roskilde Festival er en udenfor, 'leve i et telt' oplevelse, hvor du har det sjovt på en ny måde med alle dine venner, mens du nyder de mange musik-muligheder, de tilbyder hvert år.";
                eventLysfest = @" Lys Fest begivenheden giver dig som besøgende i løbet af denne vidunderlige begivenhed, muligheden for at have en vidunderlig tid med din familie og venner. Nyd musikken, folket og den smukke udsigt på dette fantastiske begivenhed";
                eventHavnen = @"Havne begivenheden giver dig som besøgende i løbet af denne vidunderlige begivenhed, muligheden for at have en vidunderlig tid med din familie og venner. Nyd musikken, folket og den smukke udsigt på dette fantastiske begivenhed";
                eventMusicon = @"Musicon begivenheden giver dig som besøgende i løbet af denne vidunderlige begivenhed, muligheden for at have en vidunderlig tid med din familie og venner. Nyd musikken, folket og den smukke udsigt på dette fantastiske begivenhed";

                shoppingsRoTorv = @"Leder du efter en god tid med venner og familie? eller søger du efter den perfekte souvenair til at bringe med hjem? Så er Bjergtrolden det perfekte sted at gøre det! Ro's Torv tilbyder dig en stor variation af alt fra nips til den særlige ting, du har ledt efter i en levetid!";
                shoppingsGaaGade = @"Leder du efter en god tid med venner og familie? eller søger du efter den perfekte souvenair til at bringe med hjem? Så er Bjergtrolden det perfekte sted at gøre det! Roskilde Gågade tilbyder dig en stor variation af alt fra nips til den særlige ting, du har ledt efter i en levetid!";
                shoppingskoebmand = @"Leder du efter en god tid med venner og familie? eller søger du efter den perfekte souvenair til at bringe med hjem? Så er Bjergtrolden det perfekte sted at gøre det! Den gamle Købmand tilbyder dig en stor variation af alt fra nips til den særlige ting, du har ledt efter i en levetid!";
                shoppingsBjergtrold = @"Leder du efter en god tid med venner og familie? eller søger du efter den perfekte souvenair til at bringe med hjem? Så er Bjergtrolden det perfekte sted at gøre det! Bjergtrolden tilbyder dig en stor variation af alt fra nips til den særlige ting, du har ledt efter i en levetid!";

                attractionVikingeSkibsMuseum = @"Er du besøger Roskilde for alle de skønheder og alle de særlige attraktioner? Derefter ser ikke yderligere, du lige har fundet en af de bedste og mest vidunderlige attraktioner i dem alle! Vikingsskibs museumm er en af de bedste oplevelser du kan finde og har med din familie eller medrejsende, mange muligheder og et kig tilbage i tiden, denne attraktion giver dig alt, hvad du har ledt efter!";
                attractionRoskildeDomkirke = @"Er du besøger Roskilde for alle de skønheder og alle de særlige attraktioner? Derefter ser ikke yderligere, du lige har fundet en af de bedste og mest vidunderlige attraktioner i dem alle! Roskilde Domkirke er en af de bedste oplevelser du kan finde og har med din familie eller medrejsende, mange muligheder og et kig tilbage i tiden, denne attraktion giver dig alt, hvad du har ledt efter!";
                attractionEtGallery = @"Er du besøger Roskilde for alle de skønheder og alle de særlige attraktioner? Derefter ser ikke yderligere, du lige har fundet en af de bedste og mest vidunderlige attraktioner i dem alle! Roskilde Galleri er en af de bedste oplevelser du kan finde og har med din familie eller medrejsende, mange muligheder og et kig tilbage i tiden, denne attraktion giver dig alt, hvad du har ledt efter!";
                attractionRaadhus = @"Er du besøger Roskilde for alle de skønheder og alle de særlige attraktioner? Derefter ser ikke yderligere, du lige har fundet en af de bedste og mest vidunderlige attraktioner i dem alle! Det gamle rådhus er en af de bedste oplevelser du kan finde og har med din familie eller medrejsende, mange muligheder og et kig tilbage i tiden, denne attraktion giver dig alt, hvad du har ledt efter!";

                #endregion
            }
            else if (LanguageFromFile.Equals("English"))
            {
                #region English version
                restaurentJensensBøfhus = @"the restaurant Jensens Bøfhus is a extremely cozy and fantastic restaurant, where as you both as new lovers aswell as lovers for several decades
have the oppertunity to have a wonderful and fantastic evening, with amazing food and some really excellent service. Jensens Bøfhus have for many years delivered this fantastic service to all that visits.
Have have the same Oppertunity and can contact them on:
phone: 29432313

and they are opened:
mon-fri 17-22
sat-sun 17-23";
                restaurentBones = @" the restaurant Bones is a extremely cozy and fantastic restaurant, where as you both as new lovers aswell as lovers for several decades
have the oppertunity to have a wonderful and fantastic evening, with amazing food and some really excellent service. Bones have for many years delivered this fantastic service to all that visits.
Have have the same Oppertunity and can contact them on:
phone: 22445566

and they are opened:
mon-fri 17-22
sat-sun 17-23";
                restaurentCafeVivaldi = @"the Café Vivaldi is a extremely cozy and fantastic restaurant, where as you both as new lovers aswell as lovers for several decades
have the oppertunity to have a wonderful and fantastic evening, with amazing food and some really excellent service. Vivaldi have for many years delivered this fantastic service to all that visits.
Have have the same Oppertunity and can contact them on:
phone: 43864397

and they are opened:
mon-fri 17-22
sat-sun 17-23";
                restaurentMumm = @"the restaurant Mumm is a extremely cozy and fantastic restaurant, where as you both as new lovers aswell as lovers for several decades
have the oppertunity to have a wonderful and fantastic evening, with amazing food and some really excellent service. Mumm have for many years delivered this fantastic service to all that visits.
Have have the same Oppertunity and can contact them on:
phone: 23154673

and they are opened:
mon-fri 17-22
sat-sun 17-23";

                eventRoskildeFestival = @"The Roskilde Festival are one of the biggest attractions in Roskilde, and attract several thousands of people to the city every year for this
amazing event, Roskilde Festival is a outside, 'living in a tent' experience where you have fun in a new way with all your friends, while you enjoy the many music options they offer every year.";
                eventLysfest = @"the Light Fest offers you as a visitor during this wonderful event, the oppertunity to have a wonderful time with your family and friends. Enjoy the music, the people and the beautiful view at this amazing event";
                eventHavnen = @"the Roskilde docks offers you as a visitor during this wonderful event, the oppertunity to have a wonderful time with your family and friends. Enjoy the music, the people and the beautiful view at this amazing event";
                eventMusicon = @"the Musicon event offers you as a visitor during this wonderful event, the oppertunity to have a wonderful time with your family and friends. Enjoy the music, the people and the beautiful view at this amazing event";

                shoppingsRoTorv = @"Are you looking for a good time with friends and family? are you searching for the perfect souvenair to bring back home? Then Ro's Torv is the perfect place to do so! Ro's Torv Offers you a large verity of everything from nips to a special item you have been searching for in a lifetime!";
                shoppingsGaaGade = @"Are you looking for a good time with friends and family? are you searching for the perfect souvenair to bring back home? Then the Roskilde GaaGade is the perfect place to do so! Roskilde Gaagade Offers you a large verity of everything from nips to a special item you have been searching for in a lifetime!";
                shoppingskoebmand = @"Are you looking for a good time with friends and family? are you searching for the perfect souvenair to bring back home? Then the Old Merchant is the perfect place to do so! the Old Merchant Offers you a large verity of everything from nips to a special item you have been searching for in a lifetime!";
                shoppingsBjergtrold = @"Are you looking for a good time with friends and family? are you searching for the perfect souvenair to bring back home? Then BjergTrolden is the perfect place to do so! BjergTrolden Offers you a large verity of everything from nips to a special item you have been searching for in a lifetime!";

                attractionVikingeSkibsMuseum = @"Are you visiting Roskilde for all of the beauties and all of the special attractions? Then look no further, you have just found one of the best and most wonderful attractions of them all! the Viking ship museum is one of the best experiences you can find and have with your family or fellow travelers, with alot of oppertunities and a look back in time, this attraction gives you everything you have been searching for!";
                attractionRoskildeDomkirke = @"Are you visiting Roskilde for all of the beauties and all of the special attractions? Then look no further, you have just found one of the best and most wonderful attractions of them all! Roskilde Domkirke is one of the best experiences you can find and have with your family or fellow travelers, with alot of oppertunities and a look back in time, this attraction gives you everything you have been searching for!";
                attractionEtGallery = @"Are you visiting Roskilde for all of the beauties and all of the special attractions? Then look no further, you have just found one of the best and most wonderful attractions of them all! Roskilde Gallery is one of the best experiences you can find and have with your family or fellow travelers, with alot of oppertunities and a look back in time, this attraction gives you everything you have been searching for!";
                attractionRaadhus = @"Are you visiting Roskilde for all of the beauties and all of the special attractions? Then look no further, you have just found one of the best and most wonderful attractions of them all! The old Town Hall is one of the best experiences you can find and have with your family or fellow travelers, with alot of oppertunities and a look back in time, this attraction gives you everything you have been searching for!";

                #endregion
            }
            else if (LanguageFromFile.Equals("French"))
            {
                #region French version
                restaurentJensensBøfhus = @"le restaurant Jensens Bøfhus est un restaurant très confortable et fantastique, où que vous tant nouveaux amants Aswell que les amateurs depuis plusieurs décennies
avoir l'oppertunity d'avoir un merveilleux et fantastique soir, avec de la nourriture incroyable et certains vraiment excellent service. Jensens Bøfhus ont depuis de nombreuses années livré ce service fantastique à tous qui visite.
Avoir le même Oppertunity et peut les contacter sur:
Téléphone: 23154673

et ils sont ouverts:
Lun-ven 17-22
sam-dim 17-23";
                restaurentBones = @"le restaurant Bones est un restaurant très confortable et fantastique, où que vous tant nouveaux amants Aswell que les amateurs depuis plusieurs décennies
avoir l'oppertunity d'avoir un merveilleux et fantastique soir, avec de la nourriture incroyable et certains vraiment excellent service. Bones ont depuis de nombreuses années livré ce service fantastique à tous qui visite.
Avoir le même Oppertunity et peut les contacter sur:
Téléphone: 23154673

et ils sont ouverts:
Lun-ven 17-22
sam-dim 17-23";
                restaurentCafeVivaldi = @"le Café Vivaldi est un restaurant très confortable et fantastique, où que vous tant nouveaux amants Aswell que les amateurs depuis plusieurs décennies
avoir l'oppertunity d'avoir un merveilleux et fantastique soir, avec de la nourriture incroyable et certains vraiment excellent service. Vivaldi ont depuis de nombreuses années livré ce service fantastique à tous qui visite.
Avoir le même Oppertunity et peut les contacter sur:
Téléphone: 23154673

et ils sont ouverts:
Lun-ven 17-22
sam-dim 17-23";
                restaurentMumm = @"le restaurant Mumm est un restaurant très confortable et fantastique, où que vous tant nouveaux amants Aswell que les amateurs depuis plusieurs décennies
avoir l'oppertunity d'avoir un merveilleux et fantastique soir, avec de la nourriture incroyable et certains vraiment excellent service. Mumm ont depuis de nombreuses années livré ce service fantastique à tous qui visite.
Avoir le même Oppertunity et peut les contacter sur:
Téléphone: 23154673

et ils sont ouverts:
Lun-ven 17-22
sam-dim 17-23";

                eventRoskildeFestival = @"Le festival de Roskilde sont l'une des plus grandes attractions de Roskilde, et d'attirer plusieurs milliers de personnes à la ville chaque année pour cette
événement extraordinaire, Roskilde Festival est un extérieur, l'expérience «vivre dans une tente» où vous avez le plaisir d'une façon nouvelle avec tous vos amis, tout en profitant des nombreuses options de musique qu'ils offrent chaque année.";
                eventLysfest = @"Fest Lumière vous offre en tant que visiteur lors de cet événement merveilleux, l'oppertunity d'avoir un temps merveilleux avec votre famille et amis profiter de la musique, les gens et la vue magnifique à cet événement incroyable.";
                eventHavnen = @"le Chantier vous offre en tant que visiteur lors de cet événement merveilleux, l'oppertunity d'avoir un temps merveilleux avec votre famille et amis profiter de la musique, les gens et la vue magnifique à cet événement incroyable.";
                eventMusicon = @"Le Musicon Event vous offre en tant que visiteur lors de cet événement merveilleux, l'oppertunity d'avoir un temps merveilleux avec votre famille et amis profiter de la musique, les gens et la vue magnifique à cet événement incroyable.";

                shoppingsRoTorv = @"Vous cherchez un bon moment avec des amis et la famille? vous recherchez le souvenair parfait pour ramener à la maison? Puis Torv de Ro est l'endroit idéal pour le faire! Torv de Ro's vous offre un grande vérité de tout, de lignes de contact à un article spécial que vous avez été chercher dans une vie! ";
                shoppingsGaaGade = @"Vous cherchez un bon moment avec des amis et la famille? vous recherchez le souvenair parfait pour ramener à la maison? Puis Torv de Ro est l'endroit idéal pour le faire! Roskilde Gågade vous offre un grande vérité de tout, de lignes de contact à un article spécial que vous avez été chercher dans une vie! ";
                shoppingskoebmand = @"Vous cherchez un bon moment avec des amis et la famille? vous recherchez le souvenair parfait pour ramener à la maison? Puis Torv de Ro est l'endroit idéal pour le faire! le vieux marchand vous offre un grande vérité de tout, de lignes de contact à un article spécial que vous avez été chercher dans une vie! ";
                shoppingsBjergtrold = @"Vous cherchez un bon moment avec des amis et la famille? vous recherchez le souvenair parfait pour ramener à la maison? Puis Torv de Ro est l'endroit idéal pour le faire! Bjergtrolden vous offre un grande vérité de tout, de lignes de contact à un article spécial que vous avez été chercher dans une vie! ";

                attractionVikingeSkibsMuseum = @"Êtes-vous visiter Roskilde pour toutes les beautés et toutes les attractions spéciales? Ne cherchez plus, vous avez trouvé l'une des meilleures et des plus belles attractions de tous! le musée du bateau viking est l'un des meilleurs expériences que vous pouvez trouver et avoir avec votre famille ou compagnons de voyage, avec beaucoup de oppertunities et un regard en arrière dans le temps, cette attraction vous donne tout ce que vous avez été chercher! ";
                attractionRoskildeDomkirke = @"Êtes-vous visiter Roskilde pour toutes les beautés et toutes les attractions spéciales? Ne cherchez plus, vous avez trouvé l'une des meilleures et des plus belles attractions de tous! le Cathédrale est l'un des meilleurs expériences que vous pouvez trouver et avoir avec votre famille ou compagnons de voyage, avec beaucoup de oppertunities et un regard en arrière dans le temps, cette attraction vous donne tout ce que vous avez été chercher! ";
                attractionEtGallery = @"Êtes-vous visiter Roskilde pour toutes les beautés et toutes les attractions spéciales? Ne cherchez plus, vous avez trouvé l'une des meilleures et des plus belles attractions de tous! le Roskilde Galerie est l'un des meilleurs expériences que vous pouvez trouver et avoir avec votre famille ou compagnons de voyage, avec beaucoup de oppertunities et un regard en arrière dans le temps, cette attraction vous donne tout ce que vous avez été chercher! ";
                attractionRaadhus = @"Êtes-vous visiter Roskilde pour toutes les beautés et toutes les attractions spéciales? Ne cherchez plus, vous avez trouvé l'une des meilleures et des plus belles attractions de tous! le Roskilde Mairie est l'un des meilleurs expériences que vous pouvez trouver et avoir avec votre famille ou compagnons de voyage, avec beaucoup de oppertunities et un regard en arrière dans le temps, cette attraction vous donne tout ce que vous avez été chercher! ";

                #endregion
            }
            else if (LanguageFromFile.Equals("German"))
            {
                #region German version
                restaurentJensensBøfhus = @"Das Restaurant Jensens Bøfhus ist ein sehr gemütliches und fantastisches Restaurant, wo Sie sowohl als neuen Liebhaber als Liebhaber seit mehreren Jahrzehnten aswell
haben die Chance habt, um eine wunderbare und fantastische Abend haben, mit unglaublichem Essen und ein paar wirklich exzellenten Service. Jensens Bøfhus sind seit vielen Jahren für alle, die besucht geliefert fantastischen Service.
Haben die gleiche Oppertunity und können sie auf an:
Telefon: 23154673

und sie geöffnet werden:
Mo-Fr 17-22
Sa-So 17-23";
                restaurentBones = @"Das Restaurant Bones ist ein sehr gemütliches und fantastisches Restaurant, wo Sie sowohl als neuen Liebhaber als Liebhaber seit mehreren Jahrzehnten aswell
haben die Chance habt, um eine wunderbare und fantastische Abend haben, mit unglaublichem Essen und ein paar wirklich exzellenten Service. Bones sind seit vielen Jahren für alle, die besucht geliefert fantastischen Service.
Haben die gleiche Oppertunity und können sie auf an:
Telefon: 23154673

und sie geöffnet werden:
Mo-Fr 17-22
Sa-So 17-23";
                restaurentCafeVivaldi = @"Das Café Vivaldi ist ein sehr gemütliches und fantastisches Restaurant, wo Sie sowohl als neuen Liebhaber als Liebhaber seit mehreren Jahrzehnten aswell
haben die Chance habt, um eine wunderbare und fantastische Abend haben, mit unglaublichem Essen und ein paar wirklich exzellenten Service. Vivaldi sind seit vielen Jahren für alle, die besucht geliefert fantastischen Service.
Haben die gleiche Oppertunity und können sie auf an:
Telefon: 23154673

und sie geöffnet werden:
Mo-Fr 17-22
Sa-So 17-23";
                restaurentMumm = @"Das Restaurant Mumm ist ein sehr gemütliches und fantastisches Restaurant, wo Sie sowohl als neuen Liebhaber als Liebhaber seit mehreren Jahrzehnten aswell
haben die Chance habt, um eine wunderbare und fantastische Abend haben, mit unglaublichem Essen und ein paar wirklich exzellenten Service. Mumm sind seit vielen Jahren für alle, die besucht geliefert fantastischen Service.
Haben die gleiche Oppertunity und können sie auf an:
Telefon: 23154673

und sie geöffnet werden:
Mo-Fr 17-22
Sa-So 17-23";

                eventRoskildeFestival = @"Das Roskilde Festival ist eine der größten Attraktionen in Roskilde, und ziehen mehrere tausend Menschen in die Stadt jedes Jahr für diese
                erstaunliche Ereignis ist Roskilde Festival ein außen 'lebt in einem Zelt Erfahrung' wo man Spaß haben in einer neuen Weise mit all Ihren Freunden, während Sie die vielen Musik-Optionen, die sie jedes Jahr zu bieten";
                eventLysfest = @"das Licht Fest bietet Ihnen als Besucher in dieser wunderbaren Veranstaltung, um die Chance habt eine schöne Zeit mit Ihrer Familie und Freunde zu haben Genießen Sie die Musik, die Menschen und die schöne Aussicht an diesem erstaunlichen Ereignis.";
                eventHavnen = @"die Roskilde Docks bietet Ihnen als Besucher in dieser wunderbaren Veranstaltung, um die Chance habt eine schöne Zeit mit Ihrer Familie und Freunde zu haben Genießen Sie die Musik, die Menschen und die schöne Aussicht an diesem erstaunlichen Ereignis.";
                eventMusicon = @"das Musicon event bietet Ihnen als Besucher in dieser wunderbaren Veranstaltung, um die Chance habt eine schöne Zeit mit Ihrer Familie und Freunde zu haben Genießen Sie die Musik, die Menschen und die schöne Aussicht an diesem erstaunlichen Ereignis.";

                shoppingsRoTorv = @"Sie suchen nach eine gute Zeit mit Freunden und Familie? Sie sind auf der Suche nach dem perfekten souvenair, nach Hause zurück zu bringen? Dann ist Ro's Torv der perfekte Ort, dies zu tun! Ros Torv bietet Ihnen eine große Wahrheit der alles von Nips zu einem speziellen Element, das Sie auf der Suche sind für die im Leben! ";
                shoppingsGaaGade = @"Sie suchen nach eine gute Zeit mit Freunden und Familie? Sie sind auf der Suche nach dem perfekten souvenair, nach Hause zurück zu bringen? Dann ist Roskilde GåGade der perfekte Ort, dies zu tun! Ros Torv bietet Ihnen eine große Wahrheit der alles von Nips zu einem speziellen Element, das Sie auf der Suche sind für die im Leben! ";
                shoppingskoebmand = @"Sie suchen nach eine gute Zeit mit Freunden und Familie? Sie sind auf der Suche nach dem perfekten souvenair, nach Hause zurück zu bringen? Dann ist Ro Torv der perfekte Ort, dies zu tun! das alten Kauf bietet Ihnen eine große Wahrheit der alles von Nips zu einem speziellen Element, das Sie auf der Suche sind für die im Leben! ";
                shoppingsBjergtrold = @"Sie suchen nach eine gute Zeit mit Freunden und Familie? Sie sind auf der Suche nach dem perfekten souvenair, nach Hause zurück zu bringen? Dann ist Ro's Torv der perfekte Ort, dies zu tun! BjergTrolden bietet Ihnen eine große Wahrheit der alles von Nips zu einem speziellen Element, das Sie auf der Suche sind für die im Leben! ";

                attractionVikingeSkibsMuseum = @"Sind Sie besuchen Roskilde für all die Schönheiten und alle besonderen Attraktionen? Dann suchen Sie nicht weiter, haben Sie gerade eine der besten und schönsten Attraktionen von allen! Das Wikingerschiffsmuseum ist eines der besten Erfahrungen, die Sie finden können und müssen mit Ihrer Familie oder Mitreisenden, mit viel oppertunities und ein Blick zurück in der Zeit, diese Attraktion gibt Ihnen alles, was Sie gesucht haben!";
                attractionRoskildeDomkirke = @"Sind Sie besuchen Roskilde für all die Schönheiten und alle besonderen Attraktionen? Dann suchen Sie nicht weiter, haben Sie gerade eine der besten und schönsten Attraktionen von allen! Das Roskilde Kathedrale ist eines der besten Erfahrungen, die Sie finden können und müssen mit Ihrer Familie oder Mitreisenden, mit viel oppertunities und ein Blick zurück in der Zeit, diese Attraktion gibt Ihnen alles, was Sie gesucht haben!";
                attractionEtGallery = @"Sind Sie besuchen Roskilde für all die Schönheiten und alle besonderen Attraktionen? Dann suchen Sie nicht weiter, haben Sie gerade eine der besten und schönsten Attraktionen von allen! Das Roskilde Galerie ist eines der besten Erfahrungen, die Sie finden können und müssen mit Ihrer Familie oder Mitreisenden, mit viel oppertunities und ein Blick zurück in der Zeit, diese Attraktion gibt Ihnen alles, was Sie gesucht haben!";
                attractionRaadhus = @"Sind Sie besuchen Roskilde für all die Schönheiten und alle besonderen Attraktionen? Dann suchen Sie nicht weiter, haben Sie gerade eine der besten und schönsten Attraktionen von allen! Das Roskilde Rathaus ist eines der besten Erfahrungen, die Sie finden können und müssen mit Ihrer Familie oder Mitreisenden, mit viel oppertunities und ein Blick zurück in der Zeit, diese Attraktion gibt Ihnen alles, was Sie gesucht haben!";

                #endregion
            }
            else if (LanguageFromFile.Equals("Russian"))
            {
                #region Russian version
                restaurentJensensBøfhus = @"Restoran Jensens Bøfhus yavlyayetsya chrezvychayno uyutnyy i fantasticheskiy restoran , gde, kak vy oba kak novyye lyubiteley Aswell kak lyubiteley v techeniye neskol'kikh desyatiletiy
yest' oppertunity imet' prekrasnyy i fantasticheskiy vecher , s udivitel'noy pishchu, a na samom dele otlichnyy servis. Jensens bøfhus uzhe mnogo let chital etot fantasticheskiy servis dlya vsekh , kotoryy poseshchayet .
Yest' imeyut odinakovuyu Oppertunity i mozhete svyazat'sya s nimi po :
telefon: 23154673

i oni otkryty :
Pn - Pt 17-22
sb - vs 17-23";
                restaurentBones = @"Restoran Bones yavlyayetsya chrezvychayno uyutnyy i fantasticheskiy restoran , gde, kak vy oba kak novyye lyubiteley Aswell kak lyubiteley v techeniye neskol'kikh desyatiletiy
yest' oppertunity imet' prekrasnyy i fantasticheskiy vecher , s udivitel'noy pishchu, a na samom dele otlichnyy servis. Bones uzhe mnogo let chital etot fantasticheskiy servis dlya vsekh , kotoryy poseshchayet .
Yest' imeyut odinakovuyu Oppertunity i mozhete svyazat'sya s nimi po :
telefon: 23154673

i oni otkryty :
Pn - Pt 17-22
sb - vs 17-23";
                restaurentCafeVivaldi = @"Café Vivaldi yavlyayetsya chrezvychayno uyutnyy i fantasticheskiy restoran , gde, kak vy oba kak novyye lyubiteley Aswell kak lyubiteley v techeniye neskol'kikh desyatiletiy
yest' oppertunity imet' prekrasnyy i fantasticheskiy vecher , s udivitel'noy pishchu, a na samom dele otlichnyy servis. Vivaldi uzhe mnogo let chital etot fantasticheskiy servis dlya vsekh , kotoryy poseshchayet .
Yest' imeyut odinakovuyu Oppertunity i mozhete svyazat'sya s nimi po :
telefon: 23154673

i oni otkryty :
Pn - Pt 17-22
sb - vs 17-23";
                restaurentMumm = @"Restoran Mumm yavlyayetsya chrezvychayno uyutnyy i fantasticheskiy restoran , gde, kak vy oba kak novyye lyubiteley Aswell kak lyubiteley v techeniye neskol'kikh desyatiletiy
yest' oppertunity imet' prekrasnyy i fantasticheskiy vecher , s udivitel'noy pishchu, a na samom dele otlichnyy servis. Mumm uzhe mnogo let chital etot fantasticheskiy servis dlya vsekh , kotoryy poseshchayet .
Yest' imeyut odinakovuyu Oppertunity i mozhete svyazat'sya s nimi po :
telefon: 23154673

i oni otkryty :
Pn - Pt 17-22
sb - vs 17-23";

                eventRoskildeFestival = @"Festival' v Roskille yavlyayutsya odnim iz samykh bol'shikh dostoprimechatel'nostey v Roskille , i privlech' neskol'ko tysyach chelovek, v gorode s kazhdym godom k etomu
udivitel'noye sobytiye , Roskille Festival' snaruzhi, 'zhivet v palatke opyt' gde u vas yest' udovol'stviye po-novomu so vsemi vashimi druz'yami, v to vremya kak vy naslazhdayetes' mnogo variantov muzyki, kotoruyu oni predlagayut kazhdyy god.";
                eventLysfest = @"Svet Fest predlagayet Vam v kachestve gostya vo vremya etogo zamechatel'nogo sobytiya , oppertunity imet' prekrasnoye vremya s sem'yey i druz'yami Naslazhdaytes' muzykoy , lyudey i prekrasnym vidom na eto potryasayushcheye sobytiye .";
                eventHavnen = @" doki Roskille predlagayet Vam v kachestve gostya vo vremya etogo zamechatel'nogo sobytiya , oppertunity imet' prekrasnoye vremya s sem'yey i druz'yami Naslazhdaytes' muzykoy , lyudey i prekrasnym vidom na eto potryasayushcheye sobytiye .";
                eventMusicon = @"sobytiye Musicon predlagayet Vam v kachestve gostya vo vremya etogo zamechatel'nogo sobytiya , oppertunity imet' prekrasnoye vremya s sem'yey i druz'yami Naslazhdaytes' muzykoy , lyudey i prekrasnym vidom na eto potryasayushcheye sobytiye .";

                shoppingsRoTorv = @" Vy ishchete khorosheye vremya s druz'yami i sem'yey ? Vy ishchete ideal'noye souvenair , chtoby prinesti domoy ? Togda Torv Ro yavlyayetsya ideal'nym mestom dlya etogo ! Torv Ro predlagayet Vam bol'shoy istinnosti vsego ot NPV k spetsial'nomu punktu vy iskali v zhizni !";
                shoppingsGaaGade = @" Vy ishchete khorosheye vremya s druz'yami i sem'yey ? Vy ishchete ideal'noye souvenair , chtoby prinesti domoy ? Togda Torv Ro yavlyayetsya ideal'nym mestom dlya etogo ! Gaagade predlagayet Vam bol'shoy istinnosti vsego ot NPV k spetsial'nomu punktu vy iskali v zhizni !";
                shoppingskoebmand = @" Vy ishchete khorosheye vremya s druz'yami i sem'yey ? Vy ishchete ideal'noye souvenair , chtoby prinesti domoy ? Togda Torv Ro yavlyayetsya ideal'nym mestom dlya etogo ! Staryy Torgovets predlagayet Vam bol'shoy istinnosti vsego ot NPV k spetsial'nomu punktu vy iskali v zhizni !";
                shoppingsBjergtrold = @"Vy ishchete khorosheye vremya s druz'yami i sem'yey ? Vy ishchete ideal'noye souvenair , chtoby prinesti domoy ? Togda Torv Ro yavlyayetsya ideal'nym mestom dlya etogo ! Bjergtrolden predlagayet Vam bol'shoy istinnosti vsego ot NPV k spetsial'nomu punktu vy iskali v zhizni !";

                attractionVikingeSkibsMuseum = @" Vy posetit' Roskilde dlya vsekh krasavits i vse spetsial'nyye attraktsiony ? Togda smotret' ne dal'she, vy tol'ko chto nashli odin iz luchshikh i samykh zamechatel'nykh dostoprimechatel'nostey ikh vsekh! Korabl'-muzey vikingov yavlyayetsya odnim iz luchshikh perezhivaniya, kotoryye vy mozhete nayti i imet' s vashey sem'yey ili poputchikov , s mnogo iz oppertunities i vernut'sya v proshloye , eto prityazheniye dayet vam vse , chto iskal !";
                attractionRoskildeDomkirke = @" Vy posetit' Roskilde dlya vsekh krasavits i vse spetsial'nyye attraktsiony ? Togda smotret' ne dal'she, vy tol'ko chto nashli odin iz luchshikh i samykh zamechatel'nykh dostoprimechatel'nostey ikh vsekh! Korabl'-muzey vikingov yavlyayetsya odnim iz luchshikh perezhivaniya, kotoryye vy mozhete nayti i imet' s vashey sem'yey ili poputchikov , s mnogo iz oppertunities i vernut'sya v proshloye , eto prityazheniye dayet vam vse , chto iskal !";
                attractionEtGallery = @" Vy posetit' Roskilde dlya vsekh krasavits i vse spetsial'nyye attraktsiony ? Togda smotret' ne dal'she, vy tol'ko chto nashli odin iz luchshikh i samykh zamechatel'nykh dostoprimechatel'nostey ikh vsekh! Korabl'-muzey vikingov yavlyayetsya odnim iz luchshikh perezhivaniya, kotoryye vy mozhete nayti i imet' s vashey sem'yey ili poputchikov , s mnogo iz oppertunities i vernut'sya v proshloye , eto prityazheniye dayet vam vse , chto iskal !";
                attractionRaadhus = @" Vy posetit' Roskilde dlya vsekh krasavits i vse spetsial'nyye attraktsiony ? Togda smotret' ne dal'she, vy tol'ko chto nashli odin iz luchshikh i samykh zamechatel'nykh dostoprimechatel'nostey ikh vsekh! Korabl'-muzey vikingov yavlyayetsya odnim iz luchshikh perezhivaniya, kotoryye vy mozhete nayti i imet' s vashey sem'yey ili poputchikov , s mnogo iz oppertunities i vernut'sya v proshloye , eto prityazheniye dayet vam vse , chto iskal !";
                #endregion
            }
            else
            {
                #region Spanish version

                restaurentJensensBøfhus = @"el restaurante Jensens Bøfhus es un muy acogedor y un fantástico restaurante, donde como usted tanto como nuevos amantes Aswell como amantes durante varias décadas
tener el ágape para tener una maravillosa y fantástica noche, con comida increíble y algo realmente excelente servicio. Jensens Bøfhus haber durante muchos años entregado este fantástico servicio a todos los que visitan.
Tener tienen el mismo ágape y se puede contactar con ellos en:
teléfono: 23154673

y se abren:
lun-vie 17-22
sáb-dom 17-23";
                restaurentBones = @"el restaurante Bones es un muy acogedor y un fantástico restaurante, donde como usted tanto como nuevos amantes Aswell como amantes durante varias décadas
tener el ágape para tener una maravillosa y fantástica noche, con comida increíble y algo realmente excelente servicio. Bones haber durante muchos años entregado este fantástico servicio a todos los que visitan.
Tener tienen el mismo ágape y se puede contactar con ellos en:
teléfono: 23154673

y se abren:
lun-vie 17-22
sáb-dom 17-23";
                restaurentCafeVivaldi = @"el Café Vivaldi es un muy acogedor y un fantástico restaurante, donde como usted tanto como nuevos amantes Aswell como amantes durante varias décadas
tener el ágape para tener una maravillosa y fantástica noche, con comida increíble y algo realmente excelente servicio. Vivaldi haber durante muchos años entregado este fantástico servicio a todos los que visitan.
Tener tienen el mismo ágape y se puede contactar con ellos en:
teléfono: 23154673

y se abren:
lun-vie 17-22
sáb-dom 17-23";
                restaurentMumm = @"el restaurante Mumm es un muy acogedor y un fantástico restaurante, donde como usted tanto como nuevos amantes Aswell como amantes durante varias décadas
tener el ágape para tener una maravillosa y fantástica noche, con comida increíble y algo realmente excelente servicio. Mumm haber durante muchos años entregado este fantástico servicio a todos los que visitan.
Tener tienen el mismo ágape y se puede contactar con ellos en:
teléfono: 23154673

y se abren:
lun-vie 17-22
sáb-dom 17-23";

                eventRoskildeFestival = @"El Festival de Roskilde es una de las mayores atracciones en Roskilde, y atraer a varios miles de personas a la ciudad cada año para este
evento increíble, Festival de Roskilde es un fuera, 'viviendo en una tienda experiencia' en la que te diviertas en una nueva forma con todos sus amigos, mientras disfruta de las muchas opciones de música que ofrecen cada año.";
                eventLysfest = @"el festival de la luz que ofrece calidad de visitante durante este maravilloso evento, el ágape para tener un tiempo maravilloso con su familia y amigos disfrutan de la música, la gente y la hermosa vista en este evento increíble";
                eventHavnen = @"los muelles Roskilde le ofrece como visitante durante este maravilloso evento, el ágape para tener un tiempo maravilloso con su familia y amigos disfrutan de la música, la gente y la hermosa vista en este evento increíble.";
                eventMusicon = @" el evento Musicon le ofrece como visitante durante este maravilloso evento, el ágape para tener un tiempo maravilloso con su familia y amigos disfrutan de la música, la gente y la hermosa vista en este evento increíble.";

                shoppingsRoTorv = @"¿Está buscando un buen rato con los amigos y la familia? estás buscando el souvenair perfecto para llevar de vuelta a casa? Entonces Torv de Ro es el lugar perfecto para hacerlo! Torv de Ro le ofrece una gran verdad de todo, desde líneas de contacto a un elemento especial que usted ha estado buscando en la vida!";
                shoppingsGaaGade = @"¿Está buscando un buen rato con los amigos y la familia? estás buscando el souvenair perfecto para llevar de vuelta a casa? Entonces Roskilde Gågade es el lugar perfecto para hacerlo! Torv de Ro le ofrece una gran verdad de todo, desde líneas de contacto a un elemento especial que usted ha estado buscando en la vida!";
                shoppingskoebmand = @"¿Está buscando un buen rato con los amigos y la familia? estás buscando el souvenair perfecto para llevar de vuelta a casa? Entonces Torv de Ro es el lugar perfecto para hacerlo! viejo comerciante le ofrece una gran verdad de todo, desde líneas de contacto a un elemento especial que usted ha estado buscando en la vida!";
                shoppingsBjergtrold = @"¿Está buscando un buen rato con los amigos y la familia? estás buscando el souvenair perfecto para llevar de vuelta a casa? Entonces Bjergtrolden es el lugar perfecto para hacerlo! Torv de Ro le ofrece una gran verdad de todo, desde líneas de contacto a un elemento especial que usted ha estado buscando en la vida!";

                attractionVikingeSkibsMuseum = @"¿Va a visitar Roskilde para todas las bellezas y todos los lugares de interés especial? ¡No busques más, has encontrado una de las mejores y más maravillosas atracciones de todos ellos! museo barco vikingo es uno de los mejores experiencias que se pueden encontrar y tener con su familia o compañeros de viaje, con un montón de oppertunities y una mirada atrás en el tiempo, esta atracción te da todo lo que usted ha estado buscando! ";
                attractionRoskildeDomkirke = @"¿Va a visitar Roskilde para todas las bellezas y todos los lugares de interés especial? ¡No busques más, has encontrado una de las mejores y más maravillosas atracciones de todos ellos! Roskilde Domkirke es una de las mejores experiencias que puede encontrar y tener con su familia o compañeros de viaje, con un montón de oppertunities y una mirada atrás en el tiempo, esta atracción te da todo lo que usted ha estado buscando! ";
                attractionEtGallery = @"¿Va a visitar Roskilde para todas las bellezas y todos los lugares de interés especial? ¡No busques más, has encontrado una de las mejores y más maravillosas atracciones de todos ellos! Roskilde Galerie es una de las mejores experiencias que puede encontrar y tener con su familia o compañeros de viaje, con un montón de oppertunities y una mirada atrás en el tiempo, esta atracción te da todo lo que usted ha estado buscando! ";
                attractionRaadhus = @"¿Va a visitar Roskilde para todas las bellezas y todos los lugares de interés especial? ¡No busques más, has encontrado una de las mejores y más maravillosas atracciones de todos ellos! Roskilde palacio de justicia es una de las mejores experiencias que puede encontrar y tener con su familia o compañeros de viaje, con un montón de oppertunities y una mirada atrás en el tiempo, esta atracción te da todo lo que usted ha estado buscando! ";

                #endregion
            }
            #endregion

            //Restaurants for detailPage.

            #region Restaurants

            Restaurants.AddAttraction("Jensens Bøfhus", restaurentJensensBøfhus, "/Assets/Eat/Jensens_Steak2.jpg");
            Restaurants.AddAttraction("Bones", restaurentBones, "/Assets/Eat/bones_steak.jpg");
            Restaurants.AddAttraction("Café Vivaldi", restaurentCafeVivaldi, "/Assets/Eat/Vivaldi_Steak2.jpg");
            Restaurants.AddAttraction("Mumm", restaurentMumm, "/Assets/Eat/Mumm_billede1.jpg");

            #endregion

            //Events for detailPage.

            #region Events

            Events.AddAttraction("Roskilde Festival", eventRoskildeFestival,
                "/Assets/Events/Roskilde_Festival_Scene.jpg");
            Events.AddAttraction("Lysfest", eventLysfest, "/Assets/Events/LysFest_billede1.gif");
            Events.AddAttraction("Havnen", eventHavnen, "/Assets/Events/Havn_front.jpg");
            Events.AddAttraction("Musicon", eventMusicon, "/Assets/Events/Musicon_billede2.jpg");

            #endregion

            //Shopping areas for detailPage.

            #region Shoppings

            Shopping.AddAttraction("Ro's Torv", shoppingsRoTorv, "/Assets/Shops/shopping_billede2.jpg");
            Shopping.AddAttraction("Gågaden", shoppingsGaaGade, "/Assets/Shops/Gaagade_billede2.gif");
            Shopping.AddAttraction("Brødrene L.", shoppingskoebmand, "/Assets/Shops/koebmand_billede1.jpg");
            Shopping.AddAttraction("Bjergtrolden", shoppingsBjergtrold, "/Assets/Shops/Trold_billede1.jpg");

            #endregion

            //Cultural areas for detailPage.

            #region Cultur

            Culture.AddAttraction("Vikinge Skibs Museum", attractionVikingeSkibsMuseum,
                "/Assets/Museum/viking_billede1.jpg");
            Culture.AddAttraction("Roskildes Domkirke", attractionRoskildeDomkirke,
                "/Assets/Museum/Domkirke_billede2.jpg");
            Culture.AddAttraction("Galleri LABR", attractionEtGallery, "/Assets/Museum/Galleri_billede2.jpg");
            Culture.AddAttraction("Rådhuset", attractionRaadhus, "/Assets/Museum/Radhus_billede1.JPG");

            #endregion

            #region Comments
            Restaurants.AttractionLists[0].AddComment("Fantastisk hyggeligt sted");
            Restaurants.AttractionLists[0].AddComment("wow what a nice steak!");
            Restaurants.AttractionLists[0].AddComment("Lidt for mange børn til min smag");
            Restaurants.AttractionLists[0].AddComment("en rigtig god kombination af det hele");
            Restaurants.AttractionLists[1].AddComment("hold da op de laver god mad");
            Restaurants.AttractionLists[1].AddComment("alt for mange mennesker!");
            Restaurants.AttractionLists[1].AddComment("håber de for gjort noget ved interiøret snart");
            Restaurants.AttractionLists[1].AddComment("The most amazing service in Denmark!");
            Restaurants.AttractionLists[2].AddComment("service niveauet et helt i top!");
            Restaurants.AttractionLists[2].AddComment("super god mad, lidt for meget larm");
            Restaurants.AttractionLists[2].AddComment("alt for lang ventetid..");
            Restaurants.AttractionLists[2].AddComment("de burde seriøst få gjort noget ved de servitricer!");
            Restaurants.AttractionLists[3].AddComment("hold kæft nogle lækre servitricer");
            Restaurants.AttractionLists[3].AddComment("dårlig mad...");
            Restaurants.AttractionLists[3].AddComment("lækker mad!!");
            Restaurants.AttractionLists[3].AddComment("It didn't live up the US standard..");

            Shopping.AttractionLists[0].AddComment("Ej et fedt sted! fik bare alt jeg skulle bruge");
            Shopping.AttractionLists[0].AddComment("fandt ikke en skid..");
            Shopping.AttractionLists[0].AddComment("waaay to crowded for my taste.");
            Shopping.AttractionLists[0].AddComment("service disken er til grin!");
            Shopping.AttractionLists[1].AddComment("ej et hyggeligt sted :-)");
            Shopping.AttractionLists[1].AddComment("Waow virkelig godt indrettet!");
            Shopping.AttractionLists[1].AddComment("fandt intet brugbart her...");
            Shopping.AttractionLists[1].AddComment("fantastisk godt miljø");
            Shopping.AttractionLists[2].AddComment("super glade mennesker her");
            Shopping.AttractionLists[2].AddComment("folk virker ikke så stresset her");
            Shopping.AttractionLists[2].AddComment("HVORFOR KAN JEG ALDRIG FINDE NOGET HER??");
            Shopping.AttractionLists[2].AddComment("på tur med svigermor... super hyggeligt");
            Shopping.AttractionLists[3].AddComment("ej et dejligt sted");
            Shopping.AttractionLists[3].AddComment("virkelig dårligt indrettet");
            Shopping.AttractionLists[3].AddComment("flotte farver de har valgt her, smukke butikker");
            Shopping.AttractionLists[3].AddComment("dat service!!");

            Culture.AttractionLists[0].AddComment("most amazing experience ever!");
            Culture.AttractionLists[0].AddComment("en helt anden oplevelse end jeg havde regnet med");
            Culture.AttractionLists[0].AddComment("so boring zzzzzzzz...");
            Culture.AttractionLists[0].AddComment("this place is really, really great.");
            Culture.AttractionLists[1].AddComment("hold da op for en fed oplevelse!");
            Culture.AttractionLists[1].AddComment("waow de havde mange flotte ting");
            Culture.AttractionLists[1].AddComment("helt sikkert et sted jeg skal hen igen");
            Culture.AttractionLists[1].AddComment("synes det var lidt kedeligt..");
            Culture.AttractionLists[2].AddComment("hold da mauvle for nogle flotte ting de har");
            Culture.AttractionLists[2].AddComment("jeg kunne virkelig godt lide deres indretning");
            Culture.AttractionLists[2].AddComment("lidt kedeligt..");
            Culture.AttractionLists[2].AddComment("helt sikkert et sted jeg skal hen igen.");
            Culture.AttractionLists[3].AddComment("god i'm bored");
            Culture.AttractionLists[3].AddComment("helt sikkert! skal helt sikkert herhen igen");
            Culture.AttractionLists[3].AddComment("virkelig flot udstilling");
            Culture.AttractionLists[3].AddComment("ikke lige mig, men virkelig flot..");

            Events.AttractionLists[0].AddComment("JEG ER FUUUULD");
            Events.AttractionLists[0].AddComment("WHAAAHHAAA NEEEXT YEAARRR");
            Events.AttractionLists[0].AddComment("ERH MAH GHERD GREATEST EVENT EVUR");
            Events.AttractionLists[0].AddComment("dårligt setup i år");
            Events.AttractionLists[1].AddComment("noget helt andet end jeg lige havde forventet");
            Events.AttractionLists[1].AddComment("hoold da op hvor var det flot");
            Events.AttractionLists[1].AddComment("helt sikkert noget vi skal igen");
            Events.AttractionLists[1].AddComment("hele familien elskede det!");
            Events.AttractionLists[2].AddComment("utrolig flot, helt sikkert");
            Events.AttractionLists[2].AddComment("fantastisk oplevelse");
            Events.AttractionLists[2].AddComment("lidt kedeligt i forhold til sidste år");
            Events.AttractionLists[2].AddComment("glæder mig til næste år allerede!");
            Events.AttractionLists[3].AddComment("ej hvor var det fedt!!");
            Events.AttractionLists[3].AddComment("I will be sure to bring my whole family next year!");
            Events.AttractionLists[3].AddComment("godt nok kedeligt...");
            Events.AttractionLists[3].AddComment("fantastisk oplevelse!!");
            #endregion

        }

        public async void GetLanguage()
        {
            LanguageFromFile = await FileHandling.LoadLanguageAsync();
        }

        #region PC

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
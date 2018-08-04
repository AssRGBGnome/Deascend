//start of the game
alert("hello adventurer! Are you ready to begin? \n Press any key to start.")

//place select
document.addEventListener('keydown', function(event) {
    if(event.keyCode == 82) {
        window.location.reload();
    }
    else if(event.keyCode == 39) {
        alert('Right was pressed');
    }
});

var place = prompt("Which place? \n 1.Dungeon \n 2.Hell \n 3.Fairy Garden \n 4.Abandoned Cave \n 5.Rainbow Land \n 6.Digging");
if(place == "1"){
    alert("you're going to the Dungeon.");
    alert("while walking stunningly in the Dungeon you notice an armour piece. Take it?")
    var choice1 = prompt("yes or no?");
    if(choice1 == "yes"){
        alert("you take the armour piece and strap it on to your clearly defined body. you stand and admire yourself for a while.")
    }
    else{
        alert("you do know if you don't take it you'll die right. Just take it...")
        alert("you take the armour piece and strap it on to your clearly defined body. you were completely wrong about not taking it; you admire your look for a while.")
    }
}
if(place == "2"){
    alert("you're going to Hell.");
    alert("good for you...i'm still loyal to you");
}
if(place == "3"){
    alert("you're going to the Fairy Garden.");
    alert("you are happily skipping along but then...*conk; you died. As it turns out gays are quite violent with each other.");
}
if(place == "4"){
    alert("you're going to the Abandoned Cave.");
}
if(place == "5"){
    alert("you're going to Rainbow Land.");
    alert("what a faggot, oh i mean nice for you.");
    alert("as you gallop across the land you find yourself in a predicament. a path indicating two signs.");
    var choice2 = prompt("which way \n 1.gays4us \n 2.bear club?");
    if(choice2 == 1){
        alert("you decide to go to the gayest, i mean coolest in the land gays4us.");
        alert("as you walk into the huge place you see thousands apon thousands of gays running right towards you. i guess they just want some meat.");
        alert("as you are franticly trying to dodge the gays you notice a piece of meat and head towards it.");
        var choice3 = prompt("pick it up? \n yes \n no");
            if(choice3 == "yes"){
                alert("you pick up the slab of meat very slowly and grab it triumphantly. everyone looks at it with enlarged pupils. they run at you with blistering speed.");
                alert("one guy was so excited to get it he toppled you over on your back and started to grab it.");
                alert("you decide before everyone comes on to you to throw the piece of meat either wise they will have yours.")
                alert("before anyone could grab it you throw it all the way across the store.");
                alert("surprisingly...it worked! They really wanted it.");
                alert("so with that distraction adverted you finally get to get what you came here for...");
                alert("condoms. despite being in a gay store you grab the most heterosexual thing in the store...well it has 2 men on the cover but it will do fine.");
                alert("you grab it and start to look for the cash register which is nowhere to be seen. i guess he was busy with the low hanging fruit in the other corner of the store.");
                alert("not wanting to be re attracted by the people in the store you leave with free products.");
                alert("having free condoms, a nice breeze, you end your adventure for the day.")
            }
            if(choice3 == "no"){
                alert("you decide to not pickup the slab of meat and accept your fate.");
                alert("gay men topple over you one by one ravaging you...you like it...alot");
                alert("in fact you like it so much you begin to allow everyone taking turns.");
                alert("many hours later you walk out of the store having no idea what you came there for and a bunch of men's numbers...you end your adventure for the day.")
            }
        }
    }
    if(choice2 == 2){
        alert("you decide to go to the mysterious place called...bear club...wonder what is there?");
        alert("as you walk into this fancy bar you see every person dart their eyes right at you. after a unusually long time of looking at you they steer away. relief flushes your mind.");
        alert("you take a seat at the bar top and ask for a drink");
        var choice4 = prompt("which drink? \n 1.whiskey \n 2.wine \n 3.coffee");
        if(choice4 == "1"){
            alert("as you ask for a glass of whiskey a tall man behind you said i've got your tab. you look at him as if to say thank you; he smiles at you.");
            alert("he sits down right next to you and stays there for a while.");
            alert("after having 4 full glasses of whiskey he says i would take care of you...");
            alert("being drunk you respond...");
            var choice5 = prompt("what do you respond with \n 1.i would allow you gladly. \n 2.fuck off.");
            if(choice5 == "1"){
                alert("you say that you would allow him gladly and he smiles. he asks if you can come back to his apartment and you say absolutely with an excited facial expression.");
                alert("you walk to his apartment with him and get enticed with his stories, he out of the blue asks you a question.");
                var choice6 = prompt("what kind of movies do you like? \n 1.action \n 2.horror \n 3.romance");
                if(choice6 == "1"){
                    alert("you say that you like action movies and he responds back.");
                    alert("i like action movies too, do you want to go drop your stuff by my place and watch the new triggerkill movie at the theater?");
                    alert("you say of course and after walking into his place and putting your stuff down he and you leave for the theater.");
                    alert("you guys are watching the movie happy with each other.");
                    alert("he, halfway puts his hand on your back and you allow him to do it, gladly.");
                    alert("after the movie he and you walk back to his place having had a really good time at the movies.");
                    alert("he gives you his phone number, 8675309 and offers that you can come by any time.");
                    alert("as you leave he waves at you leaving, you wave back with a bright smile.");
                    alert("having a new friend and a good time you end your adventure for the day.");
                }
                if(choice6 == "2"){
                    alert("you say that you like action movies and he responds back.");
                    alert("i love horror movies, they are my favorite, do you want to go drop your stuff by my place and watch the new ghost in manhattan movie at the theater?");
                    alert("you say of course and after walking into his place and putting your stuff down he and you leave for the theater.");
                    alert("you guys are watching the movie happy with each other.");
                    alert("he, halfway through the movie gets startled by one part and i come to comfort him, he feels soothed.");
                    alert("after the movie he and you walk back to his place having had a really good time at the movies.");
                    alert("he gives you his phone number, 8675309 and offers that you can come by any time.");
                    alert("as you leave he waves at you leaving, you wave back with a bright smile.");
                    alert("having a new friend and a good time you end your adventure for the day.");
                }
                if(choice6 == "3"){
                    alert("you say that you like romantic movies and he responds back.");
                    alert("i like some romantic moview, lets go for it, do you want to go drop your stuff by my place and watch the new love at first site movie at the theater? heard it was really good.");
                    alert("you say of course and after walking into his place and putting your stuff down he and you leave for the theater.");
                    alert("you guys are watching the movie happy with each other.");
                    alert("he, halfway puts his hand on your back and you allow him to do it, gladly. perfectly fitting the mood.");
                    alert("after the movie he and you walk back to his place having had a really good time at the movies.");
                    alert("he gives you his phone number, 8675309 and offers that you can come by any time.");
                    alert("as you leave he waves at you leaving, you wave back with a bright smile.");
                    alert("having a new friend and a good time you end your adventure for the day.");
                }
            }
            if(choice5 == "2"){
                alert("you say fuck off to him in a mild manner and he walks away. you enjoy your night at the bar and end your adventure for the day.");
            }
        }
        if(choice4 == "2"){
            alert("you as for a glass of wine and a man behind you says i have got ze tab for youe.");
            alert("he is very french and you like it, he sits down right next to you and offers a baguette; you take a piece of it and eat it with your wine.");
            alert("after 2 glasses of wine he says, hey i don't know youe but i would care to go out to the films tonight noue?");
            var choice7 = prompt("go to the movies with him \n 1.yes gladly 2.no thank you, thanks for the wine and baguette though.");
            if(choice7 == "yes"){
                alert("you respond saying i'm feeling that too as well. he jumps up in french filled excitement and brings you to the theater with even more baguettes and fun times in store.");
                alert("being in the zone to watch a movie you both agree on one, that being a romantic movie called a night to remember.");
                alert("you guys watch the movie and are enjoying it.");
                alert("he is enjoying it so much that half way through the movie at the climax he sobs on your shoulder.");
                alert("you confort him and both of you enjoy the rest of the movie.");
                alert("when the movie was done he gave you his number and said call me lehter.");
                alert("you say i will and both of you smile and wave to each other.");
                alert("having a good time and a new friend you end your adventure here for the day.");
            }
            if(choice7 == "no"){
                alert("as you respond he is very relieved that you didn't say anything rude.");
                alert("he says i understand, i just want to chill out too. you respond with yes, i would like that very much. he nods.");
                alert("after 3 glasses of wine each for you, both of you go home after he gives you a celebratory baguette and his phone number.");
                alert("feeling tipsy and great with a new friend you end your adventure for the day.");
            }
        }
        if(choice4 == "3"){
            alert("you ask for a cup of java and a person calmly behind you said i've got your bill if you want me to.");
            alert("you said that you would highly appreciate it.");
            alert("he sits down by you, he is very self reserved and looks like he wanted to just do something nice for a person at the bar.");
            alert("you say thank you very much for getting you a cup of coffee. he said no problem, you look like a very nice person so i figure i'd do you a solid.");
            alert("you smile at him with a thankful smile and he smiles back.");
            alert("having both of you drank a cup of java he asks, hey do you want to come by my place?");
            alert("having him being very nice to you and wanting to you say i would really like that.");
            alert("you arrive at his apartment and you see that he is a huge nerd. he has a shelf dedicated to pop vinyls of popular video game characters such as megaman, samus, link, zelda, mario, and more.");
            alert("he has a custom built pc with really cool lighting and you ask about the specs.");
            alert("he jumps in excitement saying, your a computer fan too? you say yeah! he states that the computer has a 1080ti graphics card, a 6 core intel extreme edition, 32gb of ram, and a bunch of led customizable comonents. you stand there astonished.");
            alert("after nerding out about his computer for 5 minutes he asks do you want to play a game?");
            alert("yes, you excitedly claimed.");
            alert("what game do you want to play?");
            var choice8 = prompt("which game will you play? \n 1.the binding of isaac \n 2.hollow knight \n 3.rocket league");
            if(choice8 == "1"){
                alert("you said looking at his steam library the binding of isaac rebirth. he looks like he just found the only person on the planet who likes that game.");
                alert("wow, i didn't know people played that game around here.");
                alert("i'm surprised too i said. not many people play indie games.");
                alert("he boots up binding of isaac and you both play in co-op mode. you both are having alot of fun. at one point you both we're on the mega satan fight with the most undesired setup of all time in isaac and both of you clenching tight pulled it though and won amazingly against all odds. both of you screamed heck yeah! and gave each other high fives.");
                alert("after playing for 3 hours he said i really enjoyed that, thanks for coming. you responded it was my pleasure and thanks for the coffee. he said that you could come over at anytime to play anything with him, you said i will look forward to the next time i come over.");
                alert("after packing up and going out the door you waved with a smile and he smiled and waved back excitedly.");
                alert("having a new, non gay, friend and having a ton of fun playing you end your adventure for the day.");
            }
            if(choice8 == "2"){
                alert("you said looking at his steam library hollow knight. he looks amazed that you picked that.");
                alert("have you played hollow knight? you respond no. he looks at you like your crazy and insists that you should play it.");
                alert("you happily agree and you find yourself loving the art style. it's creepy yet cute. you find yourself having alot of fun as he watches over your shoulder on the couch smiling, as if he knows what's going to happen.");
                alert("getting the map upgrades i come across a boss called the false knight, he jolts and smiles, your going to like this boss. at first it's very hard and both of us are very clutch, he says you got it!");
                alert("after stomping on the head 1 more time you beat him and both of you yell hell yeah! he goes for a high five and you high five him back.");
                alert("after playing through the first two sections he said i really enjoyed that, thanks for coming. you responded it was my pleasure and thanks for the coffee. he said that you could come over at anytime to play anything with him, you said i look forward to the next time i come over.")
                alert("after packing up and going out the door you waved with a pleasant smile and waved, he waved and smiled back excitedly as well.");
                alert("having a new, non gay, friend and having a ton of fun playing you end your adventure for the day.");
            }
            if(choice8 == "3"){
                alert("you said looking at his steam library rocket league. he looked like he was really hyped to play some rocket league and said okay!");
                alert("he booted up the game and you both played online matches with eachother. you both we're having alot of fun, at one point you both even won a doubles game with two pros at the game. when he passed the ball you unexpectedly got the last shot, winning the game. both of you yelled yes, and gave each other a giant high five.");
                alert("after playing rocket league for 3 hours he said i really enjoyed that, thanks for coming. you responded back saying it was my pleasure and thanks for the coffee. he said that you could come over at anytime to play anything with him, you said i look forward to the next time i come over.");
                alert("after packing up and going out the door you waved with a joyfilled smile and he waved back excitedly.");
                alert("having a new, non gay, friend and having a ton of fun playing you end your adventure for the day.");
            }
        }
    }
if(place == "6"){
    alert("you're going to go Digging.");
}
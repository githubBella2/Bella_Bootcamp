```mermaid
---
title: Animal example
---
classDiagram

    GameController <|-- IPlayer
    
    %% Card <|-- Player
    IPlayer <|-- ICard
   
   ICard <|-- Card : implements
    %% Card <|-- CardDeck : implements

    %% Player <|-- IPlayer : implements
    IPlayer <|-- Player: implements

    
    GameController : -IPlayer players  
    GameController : -Card deck
    GameController : +StartGame()
    GameController : +MakeMove()
    GameController : +CheckWinner()

    class ICard {
    <<interface>>
     -+~get;set;~ int number
        - +~get;set;~ string warna GetSet
        +Shuffle()
        +DrawCard()
        +GetCard()   
    }
    
    class Card{
   
    }
    class IPlayer{
    <<interface>>
        +~get;set;~ String name 
       
        +PlayCard()
    }
    
    class Player{
        -List <<Card>> cards
        +void delegate MyDelegate()
        HitungPoin()
        KartuSisaSatu(Card jumlah) //Action
    }




    %% class Player{
    %%     +String name GetSet
    %%     -List<Card> cards


    %% }

    


```
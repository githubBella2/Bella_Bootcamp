```mermaid
---
title: UNO
---
classDiagram
    ICard --o GameController 
    PlayerData --o GameController
    IPlayer --o GameController
    GameStatus --o GameController
    IPlayer <|-- Player : implements

    ICard --o PlayerData 
    ICard <|-- NumberCard : implements
    ICard <|-- SkipCard : implements
    ICard <|-- DrawTwoCard : implements
    ICard <|-- ReverseCard : implements
    ICard <|-- WildCard : implements
    ICard <|-- WildDrawFourCard : implements


    Player --o PlayerData
    Number --o NumberCard : Aggregation
    Colors --o ICard : Aggregation





    class GameController{
        -List~ICard~ _cardList
        -List~ICard~ _discardPile 
        -Dictionary ~IPlayer player~ player
        -Dictionary ~IPlayer,PlayerData~ playerData
        -int _numOfPlayer
        -IPlayer _currentPlayer 
        -GameStatus _gameStatus
        -isReverse : bool
        +GameController(int player=_numOfPlayer, ICard card, GameStatus status)
        +StartGame() : bool
        +GameStatus(_gameStatus)
        +Shuffle(ICard, _numOfPlayer, IPlayer)
        +DrawCardForNextPlayer(int count)
        +NextTurn():void
        +MakeMove(IPlayer player, ICard card) 
        +ReverseRotation() :void
        +SkipPlayer() :void
        +ChooseColor():void
        +CheckWinner(IPlayer player)
        +StopGame():bool
        
        
    }

    class IPlayer{
    <<interface>>
        +~get;set;~ String name
        +GetName() : string
    }

    class Player{
    ...
    }
    
    class PlayerData{
        +List ~ICard~ Cards
        Func ~ICard, int~ TotalKartu 
        Action ~IPlayer~ SaidUno
        Action ~ICard~ DrawCard
        +PlayCard(ICard card):void
        +Drawcard(ICard card):void
        
    }
    class Colors{
        <<enumeration>>
        Merah
        Hijau
        Biru
        Kuning
    }

    class ICard {
    <<interface>>
        %% -+~get;set;~ int number
        %% -+~get;set;~ string warna 
        +Colors warna
        +Play(GameController game)
    }

    class Number{
        <<enumeration>>
        1
        2,
        3,
        4,
        5,
        6,
        7,
        8,
        9
    }

    class NumberCard{
        +Number angka
        +NumberCard (Number angka, Colors warna)
        +GetColor(): Colors
        +GetNumber(): Number
        
    }

    class SkipCard{
        +SkipCard(Colors warna)
        +GetColor():Colors
    }
    class DrawTwoCard{
        +DrawTwoCard(Colors warna)
        +GetColor():Colors
        
    }
    class ReverseCard{
        +ReverseCard(Colors warna)
        +GetColor():Colors
    }
    class WildCard{
        +warna : null
    }
    class WildDrawFourCard{
        +warna :null
    }
    
    
   
    class  GameStatus{
    <<enumeration>>
        NotStarted,
        Play,
        Finish
    }
    


```
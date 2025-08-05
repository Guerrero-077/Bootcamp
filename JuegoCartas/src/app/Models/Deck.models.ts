import { CardModel } from "./Cards.models";
import { GamePlayerModel } from "./GamePlayer.models";

export interface DeckModel {
    id: number;
    gamePlayerId: number;
    playerName: string;
    active: boolean;
    card: CardModel;
    gamePlayer: GamePlayerModel;
}


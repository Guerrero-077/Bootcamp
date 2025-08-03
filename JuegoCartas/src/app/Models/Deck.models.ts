import { CardModel } from "./Cards.models";
import { GamePlayer } from "./GamePlayer.models";

export interface DeckModel {
    gamePlayerId: number;
    cardId: number;
    active: boolean;
    card: CardModel;
    gamePlayer: GamePlayer;
    id: number;
}

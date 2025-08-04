import { CardModel } from "./Cards.models";
import { GamePlayerModel } from "./GamePlayer.models";

export interface DeckModel {
    gamePlayerId: number;
    cardId: number;
    active: boolean;
    card: CardModel;
    gamePlayer: GamePlayerModel;
    id: number;
}

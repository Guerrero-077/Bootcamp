import { CardModel } from "./Cards.models";
import { GamePlayerModel } from "./GamePlayer.models";

export interface GamePlayerViewModel {
    player: GamePlayerModel;
    card?: CardModel; // ← carta activa si existe
}

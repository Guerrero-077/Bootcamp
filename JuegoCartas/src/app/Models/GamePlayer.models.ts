import { Player } from "./Player.models";

export interface GamePlayer {
    id:       number;
    playerId: number;
    player:   Player;
    roomId:   number;
    winner:   boolean;
}

import { Player } from "./Player.models";

export interface GameModel {
    success: boolean;
    gameId:  number;
    players: Player[];
}
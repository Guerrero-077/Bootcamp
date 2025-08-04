import { Player } from "./Player.models";

export interface GamePlayerModel {
    id: number;
    playerId: number;
    playerName: string;
    gameId: number;
    winner: number;
}
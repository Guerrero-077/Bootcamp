import { Routes } from '@angular/router';
import { CardComponent } from './Components/card-component/card-component';
import { GameComponents } from './Components/Game/game-components/game-components';
import { JugadorComponents } from './Components/jugador-components/jugador-components';
import { WaitingRoom } from './pages/WaitingRoom/waiting-room/waiting-room';

export const routes: Routes = [
    
    { path: '', component: WaitingRoom},

    // { path: '', component: HomeComponents },
    { path: 'card', component: CardComponent },
    { path: 'player', component: JugadorComponents },
    { path: 'game', component: GameComponents } 
];

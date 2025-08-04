import { Routes } from '@angular/router';
import { CardComponent } from './Components/card-component/card-component';
import { JugadorComponents } from './Components/jugador-components/jugador-components';
import { HomeComponents } from './Components/Home/home-components/home-components';
import { GameComponents } from './Components/Game/game-components/game-components';
import { ListaComponents } from './Components/lista-components/lista-components';
import { WaitingRoom } from './pages/WaitingRoom/waiting-room/waiting-room';

export const routes: Routes = [
    
    { path: '', component: WaitingRoom},

    // { path: '', component: HomeComponents },
    { path: 'card', component: CardComponent },
    { path: 'player', component: JugadorComponents },
    { path: 'game', component: GameComponents },
    { path: 'grid', component: ListaComponents },
];

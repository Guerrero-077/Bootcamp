import { Routes } from '@angular/router';
import { CardComponent } from './Components/card-component/card-component';
import { JugadorComponents } from './Components/jugador-components/jugador-components';
import { HomeComponents } from './Components/Home/home-components/home-components';

export const routes: Routes = [
    { path: '', component: HomeComponents },
    { path: 'card', component: CardComponent },
    { path: 'player', component: JugadorComponents }
];

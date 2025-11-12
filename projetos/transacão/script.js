const data = [
  {id:1,name:'Joana Silva',note:'Pagamento recebido',amount:250.00,type:'in',date:'2025-11-02',details:'Transferência via PIX — referência: SALDO-321'},
  {id:2,name:'Supermercado Bom',note:'Compra',amount:78.90,type:'out',date:'2025-11-06',details:'Cartão débito - Mercado da cidade'},
  {id:3,name:'Rendimento Juros',note:'Juros da conta',amount:1.12,type:'in',date:'2025-11-07',details:'Rendimento mensal automático'},
  {id:4,name:'Assinatura Stream',note:'Assinatura',amount:14.99,type:'out',date:'2025-11-05',details:'Plano mensal — StreamingPlus'},
  {id:5,name:'Pedro Costa',note:'Reembolso',amount:45.00,type:'in',date:'2025-10-28',details:'Reembolso por compra compartilhada'},
];
const listEl = document.getElementById('list');
const emptyEl = document.getElementById('empty');
const searchEl = document.getElementById('search');
const filterEl = document.getElementById('filter');
function money(v){return v.toLocaleString('pt-BR',{style:'currency',currency:'BRL'});} 
function render(items){
  listEl.innerHTML='';
  if(!items.length){ emptyEl.style.display='block'; return }
  emptyEl.style.display='none';
  items.forEach(tx=>{
    const item=document.createElement('div');
    item.className='tx-item'; item.setAttribute('role','listitem');
    const avatar=document.createElement('div'); avatar.className='avatar'; avatar.textContent=tx.name.split(' ').map(s=>s[0]).slice(0,2).join('');
    const meta=document.createElement('div'); meta.className='meta';
    const name=document.createElement('div'); name.className='name'; name.textContent=tx.name;
    const note=document.createElement('div'); note.className='note'; note.textContent=tx.note;
    meta.appendChild(name); meta.appendChild(note);
    const amount=document.createElement('div'); amount.className='amount '+(tx.type==='in'?'in':'out'); amount.textContent=(tx.type==='in'?'+':'−')+' '+money(tx.amount);
    const date=document.createElement('div'); date.className='date'; date.textContent=(new Date(tx.date)).toLocaleDateString('pt-BR');
    const actWrap=document.createElement('div'); actWrap.className='actions';
    const btn=document.createElement('button'); btn.className='btn'; btn.setAttribute('aria-expanded','false'); btn.textContent='Ver mais detalhes'; actWrap.appendChild(btn);
    const details=document.createElement('div'); details.className='details';
    details.innerHTML=`<p><strong>Descrição:</strong> ${tx.details}</p><p><strong>ID:</strong> ${tx.id} • <strong>Tipo:</strong> ${tx.type==='in'?'Entrada':'Saída'}</p>`;
    btn.addEventListener('click',()=>{const shown=details.classList.toggle('show');btn.setAttribute('aria-expanded',shown);btn.textContent=shown?'Esconder detalhes':'Ver mais detalhes';});
    item.append(avatar,meta,date,amount,actWrap,details);
    listEl.appendChild(item);
  });
}
function applyFilters(){
  const q=searchEl.value.toLowerCase().trim();
  const f=filterEl.value;
  const filtered=data.filter(tx=>{
    if(f!=='all'&&tx.type!==f)return false;
    if(!q)return true;
    return tx.name.toLowerCase().includes(q)||tx.note.toLowerCase().includes(q)||tx.date.includes(q)||money(tx.amount).includes(q);
  });
  render(filtered);
}
searchEl.addEventListener('input',applyFilters);
filterEl.addEventListener('change',applyFilters);
render(data);

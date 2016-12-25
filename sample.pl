% Dinh Nghia Cac Luat
% Cu phap: dinh_nghia(su_kien, dau_hieu).
% (c) Ngo Xuan Bach.


%%% BEGIN
dinh_nghia('Viem phoi','Hoa mat').
dinh_nghia('Viem phoi','Chong mat').
dinh_nghia('Viem phoi','Kho tho').
dinh_nghia('Viem phoi','Tuc nguc').
dinh_nghia('Viem phe quan','Tuc nguc').
dinh_nghia('Viem phe quan','Kho tho').
dinh_nghia('Dau da day','Dau bung').
dinh_nghia('Dau da day','Buon non').
%%% END

subset([ ],_).
subset([H|T],List) :-
    member(H,List),
    subset(T,List).

trieu_chung(Benh, L):-
	findall(T, dinh_nghia(Benh,T), L).

benh(B, Co, Khong):-
	trieu_chung(B,L),
	foreach(member(TT,Co), member(TT,L)),
	foreach(member(TT,Khong), not(member(TT,L))).

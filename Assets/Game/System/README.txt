﻿Presentation層
- Serviceとして、外から使用する機能を外だしする部分
- Monobehaviorを継承する

Application層
- ゲームの進行など、実際の処理を行う
- ユースケースの実行をし、他の層の機能を用いながら進行を行う

Infrastructure層
- ゲームの基盤となる機能
- 今回はデータベースの管理やデバッグ関係の機能

Domain層
- ゲームのルール＝ドメインを管理
　- 値オブジェクト
　- エンティティなど


Presentation -> Application / Infrastructure / Domain
Application -> Domain
Infrastructure -> Domain
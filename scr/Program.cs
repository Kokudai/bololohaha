.NET Fiddle                     
      
We Stand with Ukraine
Enter name here...
Access: 
}
371
            Console.WriteLine("Ai sim, não caiu na pegadinha"); okquest1++;
372
            Console.WriteLine();
373
        }
374
        else
375
        {
376
            Console.WriteLine();
377
            Console.WriteLine("Opaaaa, caiu no bait, a resposta certa era: 1");
378
            Console.WriteLine();            
379
        }
380
        Console.WriteLine("QUESTÃO 6:");
381
        Console.WriteLine();
382
        Console.WriteLine("Em qual ano a empresa Galpão Motoparts foi fundada?");
383
        Console.WriteLine();
384
        Console.WriteLine("a) 2020");
385
        Console.WriteLine();
386
        Console.WriteLine("b) 2018");
387
        Console.WriteLine();
388
        Console.WriteLine("c) 2011");
389
        Console.WriteLine();
390
        Console.WriteLine("d) 2015");
391
        Console.WriteLine();
392
        Console.WriteLine("e) 2017");
393
        Console.WriteLine();
394
        Console.WriteLine("Sua resposta:");
395
        
396
        string respostaquestSEIS = Console.ReadLine();
397
        
398
        if (respostaquestSEIS == "2017")
399
        {
400
            Console.WriteLine();
401
            Console.WriteLine("Era pra por a letra da alternativa seu touca, mas como eu sou daora vou aceitar kkkkkkk, certa resposta"); okquest1++;
402
            Console.WriteLine();
403
        }
404
        else if (respostaquestSEIS == "e")
405
        {
406
            Console.WriteLine();
407
            Console.WriteLine("Certa resposta mano!, isso ai");
408
            Console.WriteLine();
409
        }
410
        else
411
        {
412
            Console.WriteLine();
413
            Console.WriteLine("Tá errado mano, ta de touca mesmo, a resposta certa era: 2017");
414
            Console.WriteLine();
415
        }
416
​
417
        int totalQuest = 6;
418
        int nota = okquest1;
419
        double mediaprova = ((double)okquest1 / totalQuest) *10;
420
        double porcentagem = ((double)okquest1 / totalQuest) *100;
421
        
422
        Console.WriteLine("=== RESULTADO FINAL DA PROVA ===");
423
        Console.WriteLine();

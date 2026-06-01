<!doctype html>
<html lang="en">
<head>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <title>NUmart Transaction History Cheat Sheet</title>
  <style>
    :root {
      --ink: #18202f;
      --muted: #647084;
      --line: #dce2eb;
      --panel: #ffffff;
      --paper: #f6f8fb;
      --mint: #dff7ec;
      --mint-dark: #127752;
      --blue: #e5efff;
      --blue-dark: #285ea8;
      --rose: #ffe7e3;
      --rose-dark: #a33c2f;
      --gold: #fff3c4;
      --gold-dark: #7c5a00;
      --shadow: 0 12px 36px rgba(24, 32, 47, 0.08);
      --radius: 8px;
    }

    * { box-sizing: border-box; }
    html { scroll-behavior: smooth; }

    body {
      margin: 0;
      background: var(--paper);
      color: var(--ink);
      font-family: Arial, Helvetica, sans-serif;
      line-height: 1.5;
    }

    button, input { font: inherit; }

    .topbar {
      position: sticky;
      top: 0;
      z-index: 10;
      background: rgba(246, 248, 251, 0.94);
      border-bottom: 1px solid var(--line);
      backdrop-filter: blur(12px);
    }

    .topbar-inner {
      max-width: 1160px;
      margin: 0 auto;
      padding: 12px 18px;
      display: grid;
      grid-template-columns: 1fr auto;
      gap: 12px;
      align-items: center;
    }

    .brand {
      display: flex;
      gap: 10px;
      align-items: center;
      min-width: 0;
    }

    .brand-mark {
      width: 36px;
      height: 36px;
      border-radius: var(--radius);
      background: linear-gradient(135deg, #44b78b 0 50%, #f6cb4f 50% 100%);
      border: 1px solid rgba(24, 32, 47, 0.12);
      display: grid;
      place-items: center;
      color: #0f2a23;
      font-weight: 800;
      flex: 0 0 auto;
    }

    h1 {
      margin: 0;
      font-size: clamp(20px, 3.6vw, 34px);
      line-height: 1.08;
      letter-spacing: 0;
    }

    .subtitle {
      margin: 3px 0 0;
      color: var(--muted);
      font-size: 14px;
    }

    .search {
      width: min(360px, 38vw);
      min-width: 190px;
      border: 1px solid var(--line);
      border-radius: var(--radius);
      padding: 10px 12px;
      background: #fff;
      color: var(--ink);
    }

    main {
      max-width: 1160px;
      margin: 0 auto;
      padding: 24px 18px 48px;
    }

    .hero {
      display: grid;
      grid-template-columns: minmax(0, 1.05fr) minmax(300px, 0.95fr);
      gap: 18px;
      align-items: stretch;
      margin-bottom: 18px;
    }

    .intro, .visual-map, .section, .card, .quiz-panel {
      background: var(--panel);
      border: 1px solid var(--line);
      border-radius: var(--radius);
      box-shadow: var(--shadow);
    }

    .intro { padding: 22px; }

    .eyebrow {
      display: inline-flex;
      align-items: center;
      gap: 8px;
      padding: 5px 9px;
      border-radius: var(--radius);
      background: var(--mint);
      color: var(--mint-dark);
      font-size: 13px;
      font-weight: 700;
    }

    .intro h2, .section h2 {
      margin: 14px 0 8px;
      font-size: clamp(22px, 3vw, 32px);
      letter-spacing: 0;
    }

    .intro p, .section > p {
      margin: 0 0 14px;
      color: var(--muted);
    }

    .quick-actions {
      display: flex;
      flex-wrap: wrap;
      gap: 8px;
      margin-top: 16px;
    }

    .btn {
      border: 1px solid var(--line);
      border-radius: var(--radius);
      background: #fff;
      color: var(--ink);
      padding: 9px 11px;
      min-height: 42px;
      cursor: pointer;
      text-decoration: none;
      display: inline-flex;
      align-items: center;
      gap: 7px;
      transition: transform 120ms ease, border-color 120ms ease, background 120ms ease;
    }

    .btn:hover, .btn:focus-visible {
      transform: translateY(-1px);
      border-color: #aeb9ca;
      outline: none;
    }

    .btn.primary {
      background: var(--ink);
      color: #fff;
      border-color: var(--ink);
    }

    .visual-map {
      padding: 18px;
      overflow: hidden;
    }

    .map-title {
      font-weight: 800;
      margin-bottom: 12px;
    }

    .flow { display: grid; gap: 10px; }

    .flow-step {
      display: grid;
      grid-template-columns: 36px 1fr;
      gap: 10px;
      align-items: start;
      padding: 11px;
      border: 1px solid var(--line);
      border-radius: var(--radius);
      background: #fff;
    }

    .flow-num {
      width: 36px;
      height: 36px;
      border-radius: 50%;
      display: grid;
      place-items: center;
      font-weight: 800;
      color: #fff;
      background: var(--blue-dark);
    }

    .flow-step:nth-child(2) .flow-num { background: var(--mint-dark); }
    .flow-step:nth-child(3) .flow-num { background: var(--gold-dark); }
    .flow-step:nth-child(4) .flow-num { background: var(--rose-dark); }

    .flow-step strong { display: block; margin-bottom: 2px; }

    .flow-step span {
      color: var(--muted);
      font-size: 14px;
    }

    .tabs {
      position: sticky;
      top: 62px;
      z-index: 9;
      display: flex;
      gap: 8px;
      overflow-x: auto;
      padding: 10px 0 12px;
      background: var(--paper);
    }

    .tab {
      white-space: nowrap;
      border: 1px solid var(--line);
      border-radius: var(--radius);
      padding: 9px 12px;
      background: #fff;
      cursor: pointer;
      min-height: 40px;
    }

    .tab.active {
      background: var(--ink);
      color: #fff;
      border-color: var(--ink);
    }

    .section {
      padding: 18px;
      margin-top: 14px;
    }

    .section[hidden] { display: none; }

    .grid {
      display: grid;
      grid-template-columns: repeat(2, minmax(0, 1fr));
      gap: 12px;
    }

    .card {
      box-shadow: none;
      padding: 14px;
      min-width: 0;
    }

    .card h3 {
      margin: 0 0 8px;
      font-size: 18px;
      letter-spacing: 0;
    }

    .file-tag {
      display: inline-flex;
      border-radius: var(--radius);
      padding: 4px 8px;
      margin-bottom: 8px;
      background: var(--blue);
      color: var(--blue-dark);
      font-size: 13px;
      font-weight: 700;
    }

    .line-card {
      border: 1px solid var(--line);
      border-radius: var(--radius);
      background: #fff;
      margin: 10px 0;
      overflow: hidden;
    }

    .line-head {
      width: 100%;
      border: 0;
      background: #fff;
      color: var(--ink);
      text-align: left;
      padding: 12px;
      cursor: pointer;
      display: grid;
      grid-template-columns: auto 1fr auto;
      gap: 10px;
      align-items: center;
    }

    .line-no {
      font-weight: 800;
      color: var(--blue-dark);
    }

    .line-code {
      font-family: Consolas, "Courier New", monospace;
      font-size: 14px;
      overflow-wrap: anywhere;
    }

    .chev { color: var(--muted); }

    .line-body {
      display: none;
      padding: 0 12px 13px 12px;
      color: var(--muted);
      border-top: 1px solid var(--line);
    }

    .line-card.open .line-body { display: block; }

    pre {
      margin: 10px 0;
      padding: 12px;
      background: #101826;
      color: #f7fbff;
      border-radius: var(--radius);
      overflow-x: auto;
      font-size: 13px;
      line-height: 1.45;
    }

    code { font-family: Consolas, "Courier New", monospace; }

    .pill-row {
      display: flex;
      flex-wrap: wrap;
      gap: 8px;
      margin: 12px 0;
    }

    .pill {
      border: 1px solid var(--line);
      border-radius: var(--radius);
      background: #fff;
      padding: 8px 10px;
      cursor: pointer;
    }

    .pill.active {
      background: var(--gold);
      color: var(--gold-dark);
      border-color: #e6c95d;
      font-weight: 700;
    }

    .term-list {
      display: grid;
      grid-template-columns: repeat(3, minmax(0, 1fr));
      gap: 10px;
    }

    .term {
      border: 1px solid var(--line);
      border-radius: var(--radius);
      background: #fff;
      padding: 12px;
    }

    .term strong {
      display: block;
      margin-bottom: 5px;
    }

    .term p {
      margin: 0 0 7px;
      color: var(--muted);
      font-size: 14px;
    }

    .quiz-panel { padding: 16px; }

    .quiz-question {
      font-size: 18px;
      font-weight: 800;
      margin-bottom: 12px;
    }

    .quiz-options {
      display: grid;
      gap: 8px;
    }

    .option {
      border: 1px solid var(--line);
      border-radius: var(--radius);
      background: #fff;
      padding: 11px;
      text-align: left;
      cursor: pointer;
    }

    .option.correct {
      background: var(--mint);
      border-color: #79c9a4;
      color: var(--mint-dark);
      font-weight: 700;
    }

    .option.wrong {
      background: var(--rose);
      border-color: #ee9a8e;
      color: var(--rose-dark);
      font-weight: 700;
    }

    .feedback {
      min-height: 28px;
      margin: 12px 0 0;
      color: var(--muted);
    }

    .copy-row {
      display: flex;
      justify-content: space-between;
      gap: 8px;
      align-items: center;
      margin-top: 10px;
    }

    .small {
      color: var(--muted);
      font-size: 13px;
    }

    .no-results {
      display: none;
      padding: 14px;
      border: 1px dashed #aeb9ca;
      border-radius: var(--radius);
      color: var(--muted);
      background: #fff;
      margin-top: 12px;
    }

    @media (max-width: 820px) {
      .topbar-inner { grid-template-columns: 1fr; }
      .search { width: 100%; }
      .hero, .grid, .term-list { grid-template-columns: 1fr; }
      .tabs { top: 111px; }
    }

    @media (max-width: 520px) {
      main { padding: 16px 12px 36px; }
      .intro, .visual-map, .section { padding: 14px; }
      .line-head { grid-template-columns: 1fr auto; }
      .line-no { grid-column: 1 / 3; }
    }
  </style>
</head>
<body>
  <div class="app">
    <header class="topbar">
      <div class="topbar-inner">
        <div class="brand">
          <div class="brand-mark">NU</div>
          <div>
            <h1>Transaction History Cheat Sheet</h1>
            <p class="subtitle">Interactive guide for your NUmart code: receipt, queue, display, and terms.</p>
          </div>
        </div>
        <input id="searchInput" class="search" type="search" placeholder="Search: enqueue, append, #1, discount...">
      </div>
    </header>

    <main>
      <section class="hero">
        <div class="intro">
          <span class="eyebrow">Study mode</span>
          <h2>Follow one transaction from checkout to history.</h2>
          <p>This mini-site explains the exact lines you asked for: <strong>system.py 403-461</strong>, <strong>main.py 202-207</strong>, and <strong>structures.py 197-240</strong>. Tap any line card to see what it does.</p>
          <div class="quick-actions">
            <button class="btn primary" data-jump="system">Start with receipt</button>
            <button class="btn" data-jump="structures">Go to queue</button>
            <button class="btn" data-jump="quiz">Practice quiz</button>
          </div>
        </div>

        <aside class="visual-map" aria-label="Transaction code path">
          <div class="map-title">Code Path</div>
          <div class="flow">
            <div class="flow-step">
              <div class="flow-num">1</div>
              <div><strong>Payment succeeds</strong><span>system.py calls <code>_generate_receipt(...)</code></span></div>
            </div>
            <div class="flow-step">
              <div class="flow-num">2</div>
              <div><strong>Receipt data is prepared</strong><span>cart items become <code>items_record</code></span></div>
            </div>
            <div class="flow-step">
              <div class="flow-num">3</div>
              <div><strong>History saves it</strong><span><code>self.history.enqueue({...})</code> sends data to the Queue</span></div>
            </div>
            <div class="flow-step">
              <div class="flow-num">4</div>
              <div><strong>History displays it</strong><span>main.py calls <code>store.history.display()</code></span></div>
            </div>
          </div>
        </aside>
      </section>

      <nav class="tabs" aria-label="Cheat sheet sections">
        <button class="tab active" data-tab="overview">Overview</button>
        <button class="tab" data-tab="system">system.py</button>
        <button class="tab" data-tab="main">main.py</button>
        <button class="tab" data-tab="structures">structures.py</button>
        <button class="tab" data-tab="terms">Terms</button>
        <button class="tab" data-tab="quiz">Quiz</button>
      </nav>

      <section id="overview" class="section">
        <h2>Overview</h2>
        <p>The main idea: <code>system.py</code> creates transaction data, <code>structures.py</code> stores and prints it, and <code>main.py</code> opens the menu that shows it.</p>
        <div class="grid">
          <article class="card search-item">
            <span class="file-tag">system.py</span>
            <h3>Receipt creation</h3>
            <p>The function <code>_generate_receipt()</code> gets the date/time, copies cart items into a receipt list, subtracts inventory stock, prints the receipt, then sends the saved transaction to history.</p>
          </article>
          <article class="card search-item">
            <span class="file-tag">structures.py</span>
            <h3>Queue storage</h3>
            <p>The class <code>Queue</code> uses <code>self._data</code>, a Python list, to store transaction dictionaries. <code>append()</code> adds old-to-new. <code>insert(0, transaction)</code> makes newest appear first.</p>
          </article>
          <article class="card search-item">
            <span class="file-tag">main.py</span>
            <h3>Menu connection</h3>
            <p><code>menu_history(store)</code> clears the screen, prints the NUmart header, calls <code>store.history.display()</code>, then pauses.</p>
          </article>
          <article class="card search-item">
            <span class="file-tag">Important</span>
            <h3>Where #1 comes from</h3>
            <p><code>enumerate(self._data, start=1)</code> creates the number, and <code>Transaction #{i}</code> prints it. Remove both if you do not want transaction numbers.</p>
          </article>
        </div>
      </section>

      <section id="system" class="section" hidden>
        <h2>system.py Lines 403-461</h2>
        <p>This section creates the receipt and saves transaction data into history.</p>
        <div id="systemLines"></div>
      </section>

      <section id="main" class="section" hidden>
        <h2>main.py Lines 202-207</h2>
        <p>This menu section is the doorway to transaction history.</p>
        <div id="mainLines"></div>
      </section>

      <section id="structures" class="section" hidden>
        <h2>structures.py Lines 197-240</h2>
        <p>This class stores and displays transaction history.</p>
        <div class="pill-row" aria-label="Display order chooser">
          <button class="pill active" data-order="append">Oldest first: append</button>
          <button class="pill" data-order="insert">Newest first: insert</button>
        </div>
        <pre id="orderSnippet">def enqueue(self, transaction):
    self._data.append(transaction)</pre>
        <div id="structuresLines"></div>
      </section>

      <section id="terms" class="section" hidden>
        <h2>Terms And Origins</h2>
        <p>These are the terms you need to know and where they came from in your code.</p>
        <div id="termsGrid" class="term-list"></div>
      </section>

      <section id="quiz" class="section" hidden>
        <h2>Practice Quiz</h2>
        <p>Tap an answer. The quiz focuses on the exact transaction history flow.</p>
        <div class="quiz-panel">
          <div id="quizQuestion" class="quiz-question"></div>
          <div id="quizOptions" class="quiz-options"></div>
          <div id="feedback" class="feedback"></div>
          <div class="copy-row">
            <span id="score" class="small">Score: 0 / 0</span>
            <button id="nextQuestion" class="btn">Next question</button>
          </div>
        </div>
      </section>

      <div id="noResults" class="no-results">No matching cards found. Try searching for <code>enqueue</code>, <code>display</code>, <code>append</code>, or <code>datetime</code>.</div>
    </main>
  </div>

  <script>
    const lineGroups = {
      systemLines: [
        [403, "# ----- RECEIPT GENERATION -----", "Comment label. It marks the start of the receipt generation section."],
        [404, "def _generate_receipt(self, method, total, discounted, final):", "Defines the function that runs after a successful payment. It receives the payment method, original total, discount amount, and final paid amount."],
        [405, "\"\"\"Generate and display the receipt, then save to transaction history.\"\"\"", "Docstring. It explains that the function prints the receipt and stores it in history."],
        [406, "now       = datetime.datetime.now()", "Gets the current date and time using Python's datetime module."],
        [407, "dt_string = now.strftime(\"%Y-%m-%d %I:%M:%S %p\")", "Formats the date/time into readable text, such as 2026-06-01 08:30:15 PM."],
        [409, "items_record = []", "Creates an empty list that will store purchased item data for the receipt and history."],
        [410, "for item_data in self.cart.iter_items():", "Loops through each item in the cart. iter_items() comes from CartLinkedList in structures.py."],
        [411, "items_record.append({", "Adds one bought item as a dictionary into items_record."],
        [412, "\"name\"    : item_data[\"name\"],", "Saves the item name."],
        [413, "\"qty\"     : item_data[\"qty\"],", "Saves the purchased quantity."],
        [414, "\"subtotal\": item_data[\"subtotal\"]", "Saves the subtotal for that item."],
        [416, "inv_item = self.inventory.search(item_data[\"item_id\"])", "Finds the matching inventory item so stock can be reduced."],
        [417, "if inv_item is not None:", "Checks that the inventory item exists before changing its quantity."],
        [418, "inv_item.quantity = max(0, inv_item.quantity - item_data[\"qty\"])", "Subtracts purchased quantity from stock. max(0, ...) prevents negative stock."],
        [420, "print(f\"\\n  +-------------------------------------------+\"", "Starts printing the receipt box in the terminal."],
        [424, "f\"\\n  |  Date/Time : {dt_string:<29}|\"", "Prints the receipt date/time. <29 aligns the text inside the box."],
        [425, "f\"\\n  |  Payment   : {method:<29}|\"", "Prints the payment method used by the customer."],
        [429, "for item in items_record:", "Loops through all purchased items so they appear on the receipt."],
        [430, "name = f\"{item['name']:<24}\"", "Formats the item name to fit the receipt table."],
        [431, "qty  = f\"{item['qty']:<7}\"", "Formats the quantity column."],
        [432, "sub  = f\"₱{item['subtotal']:.2f}\"", "Formats the subtotal as money with two decimal places."],
        [433, "print(f\"  |  {name}{qty}{sub:<10}|\")", "Prints one purchased item row on the receipt."],
        [436, "total_str = f\"₱{total:.2f}\"", "Formats the original total as peso currency."],
        [437, "final_str = f\"₱{final:.2f}\"", "Formats the final amount paid as peso currency."],
        [440, "if self.discount > 0:", "Only shows the discount line if a promo discount was used."],
        [441, "discounted_str = f\"-₱{discounted:.2f}\"", "Formats the discount amount as negative peso currency."],
        [443, "print(f\"  |  TOTAL PAID: {final_str:<29}|\"", "Prints the final amount paid."],
        [449, "self.history.enqueue({", "Sends a dictionary of transaction data into the transaction history queue."],
        [450, "\"datetime\"  : dt_string,", "Stores the date/time in the transaction record."],
        [451, "\"method\"    : method,", "Stores the payment method."],
        [452, "\"total\"     : total,", "Stores the original total before discount."],
        [453, "\"discount\"  : self.discount,", "Stores the discount percentage used."],
        [454, "\"total_paid\": final,", "Stores the amount actually paid."],
        [455, "\"items\"     : items_record", "Stores the purchased items list."],
        [458, "self.cart.clear()", "Empties the cart after checkout."],
        [459, "self.discount   = 0", "Resets discount for the next transaction."],
        [460, "self.promo_used = \"\"", "Clears the promo code used."],
        [461, "self.undo_stack.clear()", "Clears undo history after checkout because the cart is finished."]
      ],

      mainLines: [
        [202, "def menu_history(store):", "Defines the menu function for viewing transaction history."],
        [203, "\"\"\"View transaction history.\"\"\"", "Docstring explaining this menu's purpose."],
        [204, "clear_screen()", "Adds blank lines so the terminal display is cleaner."],
        [205, "print_header()", "Prints the NUmart title/header."],
        [206, "store.history.display()", "Calls the Queue display() function from structures.py. This is the line that shows transaction history."],
        [207, "pause()", "Waits for ENTER before returning to the main menu."]
      ],

      structuresLines: [
        [197, "# ----- QUEUE (Transaction History) -----", "Comment label for the transaction history data structure."],
        [198, "class Queue:", "Defines the Queue class used for transaction history."],
        [199, "\"\"\"Queue (FIFO) for storing transaction history in order.\"\"\"", "Docstring. FIFO means first in, first out, usually oldest first."],
        [200, "def __init__(self):", "Constructor. Runs when Queue() is created in system.py."],
        [201, "self._data = []", "Creates the list where transaction records are stored."],
        [203, "def enqueue(self, transaction):", "Defines the function used to add a new transaction to history."],
        [204, "self._data.append(transaction)", "Adds the transaction to the end of the list. Use insert(0, transaction) if you want newest first."],
        [206, "def display(self):", "Defines the function that prints transaction history."],
        [207, "\"\"\"Print all transactions in chronological order.\"\"\"", "Docstring. Chronological order means by time order, usually oldest to newest."],
        [208, "if self.is_empty():", "Checks whether there are no saved transactions yet."],
        [209, "print(\"\\n  [!] No transaction history yet.\")", "Shows a message if history is empty."],
        [210, "return", "Stops the display function early when there is nothing to print."],
        [212, "print(\"\\n  +----------------------------------------------------------+\"", "Prints the transaction history title box."],
        [216, "for i, transaction in enumerate(self._data, start=1):", "Loops through transactions and gives each one a number. This creates i = 1, 2, 3, etc."],
        [217, "dt = transaction['datetime']", "Gets the saved date/time from the transaction dictionary."],
        [218, "method = transaction['method']", "Gets the saved payment method."],
        [219, "total      = f\"₱{transaction['total']:.2f}\"", "Formats the original total as money."],
        [220, "discount   = f\"{transaction['discount']}%\"", "Formats the discount percentage."],
        [221, "total_paid = f\"₱{transaction['total_paid']:.2f}\"", "Formats the final paid amount as money."],
        [223, "print(f\"  |  Transaction #{i:<43}|\"", "Prints Transaction #1, #2, etc. Remove this line if you do not want transaction numbers."],
        [224, "f\"\\n  |  Date/Time  : {dt:<43}|\"", "Prints the transaction date/time."],
        [225, "f\"\\n  |  Payment    : {method:<43}|\"", "Prints the payment method."],
        [226, "f\"\\n  |  Total      : {total:<43}|\"", "Prints the original total."],
        [227, "f\"\\n  |  Discount   : {discount:<43}|\"", "Prints the discount percent."],
        [228, "f\"\\n  |  Total Paid : {total_paid:<43}|\"", "Prints the final paid amount."],
        [233, "for item in transaction['items']:", "Loops through every purchased item saved inside the transaction."],
        [234, "name     = f\"{item['name']:<24}\"", "Formats the item name column."],
        [235, "qty      = f\"{item['qty']:<6}\"", "Formats the quantity column."],
        [236, "subtotal = f\"₱{item['subtotal']:.2f}\"", "Formats the item subtotal as money."],
        [237, "print(f\"  |  {name}{qty} {subtotal:<25}|\")", "Prints one purchased item row in transaction history."],
        [239, "print(\"  +----------------------------------------------------------+\")", "Prints the closing line of one transaction box."],
        [240, "", "Blank line. It has no behavior; it just helps code readability."]
      ]
    };

    const terms = [
      ["self", "The current object using a method. In NUmart, self.history means this store object's history queue.", "Comes from every class method in Python."],
      ["Queue", "A data structure for storing items in order. Your transaction history uses a Queue class.", "Defined in structures.py line 198; created in system.py as self.history = Queue()."],
      ["FIFO", "First In, First Out. The first saved transaction is displayed first when using append().", "Mentioned in the Queue docstring."],
      ["_data", "The internal list that stores all transaction dictionaries.", "Created in structures.py line 201."],
      ["transaction", "A dictionary holding one receipt's date, method, totals, discount, and items.", "Created in system.py lines 449-456."],
      ["enqueue()", "A function that adds one transaction to history.", "Defined in structures.py line 203; called in system.py line 449."],
      ["append()", "A Python list method that adds a value to the end of a list.", "Used in structures.py line 204."],
      ["insert(0, transaction)", "Adds the transaction at index 0, meaning the top/start of the list.", "Use this if you want most recent transaction first."],
      ["display()", "Shows all saved transactions in the terminal.", "Defined in structures.py line 206; called in main.py line 206."],
      ["enumerate()", "Gives both the item and a number while looping.", "Used in structures.py line 216; it creates the #1, #2, #3 numbers."],
      ["datetime", "Python module for working with dates and times.", "Imported in system.py and used in line 406."],
      ["strftime()", "Formats a date/time object into readable text.", "Used in system.py line 407."],
      ["iter_items()", "Gives each cart item one by one as a dictionary.", "Called in system.py line 410; defined in CartLinkedList."],
      ["dictionary", "A Python data type using key-value pairs like 'method': 'Cash'.", "Your transaction record is a dictionary."],
      ["list", "A Python collection that stores many values in order.", "items_record and self._data are lists."],
      ["f-string", "A formatted string that can insert variables inside text.", "Used throughout receipt and history print lines."]
    ];

    const quiz = [
      { q: "Which line sends a completed transaction into history?", options: ["self.history.enqueue({...})", "store.history.display()", "clear_screen()"], answer: 0, why: "system.py line 449 calls enqueue() and passes the transaction dictionary." },
      { q: "Why did self._data.insert(transaction) cause an error?", options: ["insert() needs index and value", "transaction was empty", "Queue cannot store dictionaries"], answer: 0, why: "insert() must be written like insert(0, transaction)." },
      { q: "What line creates Transaction #1?", options: ["enumerate(self._data, start=1)", "datetime.datetime.now()", "self.cart.clear()"], answer: 0, why: "enumerate() creates the number i, and the print line displays it." },
      { q: "What should you use for newest transaction on top?", options: ["self._data.insert(0, transaction)", "self._data.append(transaction)", "self._data.clear(transaction)"], answer: 0, why: "Index 0 means the beginning of the list, so it appears first when displayed." },
      { q: "What does store.history.display() do?", options: ["Prints transaction history", "Creates the receipt", "Deletes the cart"], answer: 0, why: "main.py line 206 calls Queue.display() from structures.py." }
    ];

    function renderLines(containerId, rows) {
      const container = document.getElementById(containerId);
      container.innerHTML = rows.map(([line, code, explanation]) => `
        <article class="line-card search-item" data-search="${escapeHtml(String(line) + " " + code + " " + explanation)}">
          <button class="line-head" type="button" aria-expanded="false">
            <span class="line-no">Line ${line}</span>
            <span class="line-code">${escapeHtml(code || "(blank line)")}</span>
            <span class="chev">+</span>
          </button>
          <div class="line-body"><p>${escapeHtml(explanation)}</p></div>
        </article>
      `).join("");
    }

    function renderTerms() {
      document.getElementById("termsGrid").innerHTML = terms.map(([term, definition, origin]) => `
        <article class="term search-item" data-search="${escapeHtml(term + " " + definition + " " + origin)}">
          <strong>${escapeHtml(term)}</strong>
          <p>${escapeHtml(definition)}</p>
          <p class="small"><strong>Path/history:</strong> ${escapeHtml(origin)}</p>
        </article>
      `).join("");
    }

    function escapeHtml(value) {
      return String(value)
        .replaceAll("&", "&amp;")
        .replaceAll("<", "&lt;")
        .replaceAll(">", "&gt;")
        .replaceAll('"', "&quot;");
    }

    renderLines("systemLines", lineGroups.systemLines);
    renderLines("mainLines", lineGroups.mainLines);
    renderLines("structuresLines", lineGroups.structuresLines);
    renderTerms();

    document.addEventListener("click", (event) => {
      const lineButton = event.target.closest(".line-head");
      if (lineButton) {
        const card = lineButton.closest(".line-card");
        const isOpen = card.classList.toggle("open");
        lineButton.setAttribute("aria-expanded", String(isOpen));
        lineButton.querySelector(".chev").textContent = isOpen ? "-" : "+";
      }

      const tabButton = event.target.closest(".tab");
      if (tabButton) activateTab(tabButton.dataset.tab);

      const jumpButton = event.target.closest("[data-jump]");
      if (jumpButton) {
        activateTab(jumpButton.dataset.jump);
        document.querySelector(".tabs").scrollIntoView({ behavior: "smooth" });
      }

      const orderButton = event.target.closest("[data-order]");
      if (orderButton) {
        document.querySelectorAll("[data-order]").forEach(btn => btn.classList.remove("active"));
        orderButton.classList.add("active");
        document.getElementById("orderSnippet").textContent = orderButton.dataset.order === "insert"
          ? "def enqueue(self, transaction):\n    self._data.insert(0, transaction)"
          : "def enqueue(self, transaction):\n    self._data.append(transaction)";
      }
    });

    function activateTab(id) {
      document.querySelectorAll(".tab").forEach(btn => btn.classList.toggle("active", btn.dataset.tab === id));
      document.querySelectorAll(".section").forEach(section => section.hidden = section.id !== id);
      applySearch();
    }

    document.getElementById("searchInput").addEventListener("input", applySearch);

    function applySearch() {
      const query = document.getElementById("searchInput").value.trim().toLowerCase();
      const visibleSection = document.querySelector(".section:not([hidden])");
      let matches = 0;

      visibleSection.querySelectorAll(".search-item").forEach(item => {
        const haystack = (item.dataset.search || item.textContent).toLowerCase();
        const show = query === "" || haystack.includes(query);
        item.style.display = show ? "" : "none";
        if (show) matches++;
      });

      document.getElementById("noResults").style.display = query && matches === 0 ? "block" : "none";
    }

    let quizIndex = 0;
    let answered = false;
    let score = 0;
    let attempts = 0;

    function renderQuiz() {
      answered = false;
      const item = quiz[quizIndex];

      document.getElementById("quizQuestion").textContent = item.q;
      document.getElementById("feedback").textContent = "";
      document.getElementById("quizOptions").innerHTML = item.options.map((option, index) => `
        <button class="option" type="button" data-option="${index}">${escapeHtml(option)}</button>
      `).join("");
      document.getElementById("score").textContent = `Score: ${score} / ${attempts}`;
    }

    document.getElementById("quizOptions").addEventListener("click", (event) => {
      const option = event.target.closest(".option");
      if (!option || answered) return;

      answered = true;
      attempts++;

      const selected = Number(option.dataset.option);
      const current = quiz[quizIndex];

      document.querySelectorAll(".option").forEach(btn => {
        const index = Number(btn.dataset.option);
        if (index === current.answer) btn.classList.add("correct");
        if (index === selected && selected !== current.answer) btn.classList.add("wrong");
      });

      if (selected === current.answer) {
        score++;
        document.getElementById("feedback").textContent = "Correct. " + current.why;
      } else {
        document.getElementById("feedback").textContent = "Almost. " + current.why;
      }

      document.getElementById("score").textContent = `Score: ${score} / ${attempts}`;
    });

    document.getElementById("nextQuestion").addEventListener("click", () => {
      quizIndex = (quizIndex + 1) % quiz.length;
      renderQuiz();
    });

    renderQuiz();
  </script>
</body>
</html>

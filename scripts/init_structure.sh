#!/usr/bin/env bash

echo "== INIT OZON PARSER STRUCTURE =="

mkdir -p Search Security Utils scripts
touch Search/OzonBrut.cs
touch Search/OzonAsync.cs
touch Security/OzonSecurity.cs
touch Utils/Logger.cs
touch ozon_last_checked_id.txt

echo "✔ Structure created"
EOFcat > scripts/reset_run.sh << 'EOF'
#!/usr/bin/env bash

echo "== RESET RUN STATE =="

rm -f ozon_last_checked_id.txt
touch ozon_last_checked_id.txt

echo "✔ last_checked_id reset"
